using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {

    public GameObject conveyor; 
    private Vector3 startP = Spawn.startPos;
    private Vector3 endP = Spawn.endPos;

    private int count = 0;
    public float speed; 

    private void OnTriggerStay2D(Collider2D other)
    {
        count++; 
        if (other.gameObject.tag == "Sheep")
        {
            //Do whatever you want 

            //Debug.Log(" WE HAVE COLLISIOn!!!!");
            other.transform.position = Vector3.MoveTowards(other.transform.position, endP, speed * Time.deltaTime);

           // Debug.Log(" endPoint X"+ endP);
           
        }
    }
   
}
