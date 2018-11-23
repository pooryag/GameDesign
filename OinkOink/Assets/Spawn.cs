using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject ballHook;

    public static int count = 0;

    public static Vector3 startPos;
    public static Vector3 endPos;
    //public Rigidbody2D conveyor;
    private bool flag = true;

    public static int ballCount = 4;
    private int blockCount;
    private float dist;
    private float interpolate;
    private Vector3 conveyorBegin;
    private Vector2 mousePos;
    private void Update()
    {
    
        if (Input.GetButton("Fire1"))
        {


            if (count == 2 && ballCount !=0)
            {
                endPos = gameObject.transform.position;
                Debug.Log("I SAID WHAT? " + count);
                Debug.Log("End Position:  " + endPos);
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject newAnchor = Instantiate(Resources.Load("BallHook", typeof(GameObject)), mousePos, Quaternion.identity) as GameObject;

                ballCount--;
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

                    //Debug.Log("interpotlate :" + interpolate);
                    conveyorBegin = Vector3.Lerp(startPos, endPos, interpolate);

                    //Debug.Log("conveyor being " + conveyorBegin);
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
        if (count == 1 && ballCount !=0)
        {
            startPos = gameObject.transform.position;
            Debug.Log("I SAID WHAT? " + count);
            Debug.Log("Start Position:  " + startPos);
        }
        //Debug.Log("I SAID WHAT? " + count);
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