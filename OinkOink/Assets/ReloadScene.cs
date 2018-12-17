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
        Spawn.ballCount = 5;
        Spawn.count = 0;
        Spawn.AnchorIndicator = 0;
        Ball.deactivateAnchor = false; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
