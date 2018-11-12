using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject ballHook;

    private int count = 0;

    private Vector3 startPos;
    private Vector3 endPos;
    //public Rigidbody2D conveyor;
    private bool flag = true;

    private int blockCount;
    private float dist;
    private float interpolate;
    private Vector3 conveyorBegin;
    private Vector2 mousePos;
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {


            if (count == 2)
            {
                endPos = gameObject.transform.position;
                Debug.Log("I SAID WHAT? " + count);
                Debug.Log("End Position:  " + endPos);
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject newAnchor = Instantiate(Resources.Load("BallHook", typeof(GameObject)), mousePos, Quaternion.identity) as GameObject;
                count = 0;
                Destroy(gameObject);
                blockCount = Mathf.RoundToInt(Vector3.Distance(startPos, endPos) / 0.5f);
                Debug.Log("blockCount :" + blockCount);
                dist = 1.0f / blockCount;

                Debug.Log("dist :" + dist);
                Vector3 direction = (startPos - endPos).normalized;

                for (int i = 0; i < blockCount-1; i++)
                {
                    interpolate += dist;

                    Debug.Log("interpotlate :" + interpolate);
                    conveyorBegin = Vector3.Lerp(startPos, endPos, interpolate);

                    Debug.Log("conveyor being " + conveyorBegin);
                    GameObject conveyor = Instantiate(Resources.Load("conveyor", typeof(GameObject))) as GameObject;
                    conveyor.transform.right = direction;

                    conveyor.transform.right *= -1f;

                    conveyor.transform.position = conveyorBegin;


                }
            }



        }
    }
    private void OnMouseDown()
    {

        count++;
        if (count == 1)
        {
            startPos = gameObject.transform.position;
            Debug.Log("I SAID WHAT? " + count);
            Debug.Log("Start Position:  " + startPos);
        }
        //Debug.Log("I SAID WHAT? " + count);
    }

    void InstantiateConveyor(GameObject conveyor, Vector3 startPos, Vector3 endPos, bool flag)
    {

        //Here we calculate how many segments will fit between the two points
        blockCount = Mathf.RoundToInt(Vector3.Distance(startPos, endPos) / 0.5f);
        //As we'll be using vector3.lerp we want a value between 0 and 1, and the distance value is the value we have to add
        dist = 1 / blockCount;
        Debug.Log("COUNT :" + blockCount);
       // for (int i = 0; i < blockCount; i++)
        //{
            //conveyor.transform.position = centerPos;
            Vector3 direction = (startPos - endPos).normalized;
            //We increase our lerpValue
            interpolate += dist;
            //Get the position
            conveyorBegin = Vector3.Lerp(startPos, endPos, interpolate);
            //Instantiate the object
            conveyor.transform.right = direction;

            if (flag) conveyor.transform.right *= -1f;

            conveyor.transform.position = conveyorBegin;
            //Instantiate(Resources.Load("conveyor", typeof(GameObject)), conveyorBegin, Quaternion.identity);


            //Instantiate(ropePrefab, instantiatePosition, transform.rotation);
            // Instantiate(Resources.Load("conveyor", typeof(GameObject)), conveyorBegin, Quaternion.identity);
        //}
    }

    /*
    public void Strech(GameObject conveyor, Vector3 startPos, Vector3 endPos, bool flag)
    {
        Vector3 centerPos = (startPos + endPos) / 2f;
        conveyor.transform.position = centerPos;
        Vector3 direction = (startPos - endPos).normalized;

        conveyor.transform.right = direction;

        if (flag) conveyor.transform.right *= -1f;
        Vector3 scale = new Vector3(1, 1, 1);
        scale.x = Vector3.Distance(startPos, endPos);
        conveyor.transform.localScale = scale;
    }*/

}