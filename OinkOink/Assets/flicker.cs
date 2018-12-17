using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour {
    Light test;
    public float min;
    public float max; 

	// Use this for initialization
	void Start () {

        test = GetComponent<Light>();
        StartCoroutine(Flash());
		
	}
	
	// Update is called once per frame
    IEnumerator Flash(){

        while(true){

            yield return new WaitForSeconds(Random.Range(min,max));
            test.enabled = !test.enabled; 
        }
    }
}
