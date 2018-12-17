using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    private gameMaster gm;
    public GameObject deathParticle;
    public GameObject winParticle;
    public GameObject winText;

    //private int count = 0;
    // Use this for initialization

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<gameMaster>();
    }
    void Update () {
		
        GetComponent<Rigidbody2D>().simulated |= Spawn.count == 2;
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("wtf");
        if (other.gameObject.tag == "Death")
        {
            Instantiate(deathParticle, transform.position, Quaternion.identity);

            switch(gameObject.name){
                case "sheepkid":
                    Debug.Log("kid is dead");
                    gm.kid = false;
                    break;
                case "sheepmom":
                    Debug.Log("mom is dead");
                    gm.mom = false;
                    break;
                case "sheepdad":
                    Debug.Log("dad is dead");
                    gm.dad = false;
                    break;
                case "sheep":
                    Debug.Log("son is dead");
                    gm.son = false;
                    break;

            }

            Destroy(gameObject);

        }
        if (other.gameObject.tag == "Heaven")
        {
            //count++;
            Instantiate(winParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            gm.heavenEntry = true; 

        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "coin")
        {

            Destroy(other.gameObject);
            gm.points++;
        }
    }



}
