using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadCurrentScene(){
        Spawn.ballCount = 3;
        Spawn.count = 0; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
