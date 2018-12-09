using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour {
    public float destroyTime = 3f;
    public Vector3 offset = new Vector3(0, 0.5f, 0);
	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyTime);
       transform.localPosition += offset;
	}
	

}
