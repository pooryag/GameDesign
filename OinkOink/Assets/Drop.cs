using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

    public GameObject deathParticle;
    public GameObject winParticle;
    public GameObject winText;
    //private int count = 0;
    // Use this for initialization
    void Update () {
		
        GetComponent<Rigidbody2D>().simulated |= Spawn.count == 2;
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("wtf");
        if (other.gameObject.tag == "Death")
        {
            Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Heaven")
        {
            //count++;
            Instantiate(winParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }

    }


}
