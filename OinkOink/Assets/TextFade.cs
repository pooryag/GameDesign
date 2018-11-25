using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour {
    public float destroyTime = 3f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyTime);
	}
	

}
