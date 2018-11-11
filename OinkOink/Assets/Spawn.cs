using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject ballHook;

    private int count = 0;

    private void Update()
    {
        if(Input.GetButton("Fire1")){
            
            if (count == 2)
            {
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject newAnchor = Instantiate(Resources.Load("BallHook", typeof(GameObject)), mousePos, Quaternion.identity) as GameObject;
                count = 0;
                Destroy(gameObject);
            }



        }
    }
    private void OnMouseDown()
    {

        count++;
        //Debug.Log("I SAID WHAT? " + count);
    }
}
