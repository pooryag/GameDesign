using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitSheep : MonoBehaviour {
    public bool win = false;
	// Use this for initialization

     

    private void OnTriggerEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Heaven")
        {
            Debug.Log("entered something");
            StartCoroutine(winDelay());

        }
       
    }



    // Update is called once per frame
    IEnumerator winDelay()
    {


            yield return new WaitForSeconds(2.0f);
            Debug.Log("WIN");
            win = true; 

    }
}
