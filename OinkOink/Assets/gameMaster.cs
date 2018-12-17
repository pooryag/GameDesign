using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameMaster : MonoBehaviour {

    public int points;
    public Text pointText;
    public bool dad = true;
    public bool mom = true;
    public bool kid = true;
    public bool son = true;
    public bool heavenEntry = false; 
    // Update is called once per frame
    void Update () {
        pointText.text = ("Points: " + points);
        if (heavenEntry){
            StartCoroutine(winDelay());
        }
	}

    IEnumerator winDelay()
    {


        yield return new WaitForSeconds(6.0f);
        Debug.Log("WIN");


    }
}
