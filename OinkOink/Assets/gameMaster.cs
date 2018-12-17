using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameMaster : MonoBehaviour {

    public int points;
    public GameObject completeLevelUI;
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


        yield return new WaitForSeconds(5.0f);
        Debug.Log("WIN");
        completeLevelUI.SetActive(true);
        if (points == 2) {
            completeLevelUI.transform.Find("coin1").gameObject.SetActive(false);
        }
        if (points == 1)
        {
            completeLevelUI.transform.Find("coin1").gameObject.SetActive(false);
            completeLevelUI.transform.Find("coin2").gameObject.SetActive(false);
        }
        if (points == 0)
        {
            completeLevelUI.transform.Find("coin1").gameObject.SetActive(false);
            completeLevelUI.transform.Find("coin2").gameObject.SetActive(false);
            completeLevelUI.transform.Find("coin3").gameObject.SetActive(false);
        }
        if (mom){
            completeLevelUI.transform.Find("head1/head1_dead").gameObject.SetActive(false);
        }else{
            completeLevelUI.transform.Find("head1/head1").gameObject.SetActive(false);
        }
        if (kid)
        {
            completeLevelUI.transform.Find("head2/head2_dead").gameObject.SetActive(false);
        }else{
            completeLevelUI.transform.Find("head2/head2").gameObject.SetActive(false);
        }
        if (dad)
        {
            completeLevelUI.transform.Find("head3/head3_dead").gameObject.SetActive(false);
        }
        else
        {
            completeLevelUI.transform.Find("head3/head3").gameObject.SetActive(false);
        }
        if (son)
        {
            completeLevelUI.transform.Find("head4/head4_dead").gameObject.SetActive(false);
        }
        else
        {
            completeLevelUI.transform.Find("head4/head4").gameObject.SetActive(false);
        }


    }
}
