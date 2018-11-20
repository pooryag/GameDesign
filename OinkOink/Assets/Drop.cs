using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

	// Use this for initialization
	void Update () {
		
        GetComponent<Rigidbody2D>().simulated |= Spawn.count == 2;
	}
	

}
