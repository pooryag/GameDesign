using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBloody : MonoBehaviour {


    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("wtf");
        if (other.gameObject.tag == "Sheep")
        {
            Instantiate(Resources.Load("blade_bloody", typeof(GameObject)), gameObject.transform.position, Quaternion.identity); 
            Destroy(gameObject);
        }
       

    }
}
