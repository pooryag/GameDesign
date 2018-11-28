using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTap : MonoBehaviour {

	public void NextScene()
    {
        SceneManager.LoadScene("MainLevel");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
