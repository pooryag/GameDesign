using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour {

    public GameObject conveyor; 
    private Vector3 startP = Spawn.startPos;
    private Vector3 endP = Spawn.endPos;
    private Vector3 direction;

    private int count = 0;
    public float speed; 

    private void OnTriggerStay2D(Collider2D other)
    {
        count++; 
        if (other.gameObject.tag == "Sheep")
        {

            //direction = transform.forward;
            //direction = direction * speed;
            //other.GetComponent<Rigidbody2D>().AddForce(direction, ForceMode2D.Force);
            //Do whatever you want 
            //float beltVelocity = speed * Time.deltaTime;
            //other.gameObject.GetComponent<Rigidbody>().velocity = beltVelocity * transform.forward;
            //Debug.Log(" WE HAVE COLLISIOn!!!!");
           other.transform.position = Vector3.MoveTowards(other.transform.position, endP, speed * Time.deltaTime);

           // Debug.Log(" endPoint X"+ endP);
           
        }
    }
   
}
