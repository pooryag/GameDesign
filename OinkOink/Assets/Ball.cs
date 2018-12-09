using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private bool isPressed = false;

    public float timer = 0.15f;

    public float maxDistance = 2.0f;

    public Rigidbody2D hook;

    public Rigidbody2D rb;
    
    public GameObject nextBall;

    public static bool deactivateAnchor = false;

    // public GameObject floatingTextPrefab;


    private void Update()
    {

       
        if (isPressed ){

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
            if ( Vector3.Distance (hook.position, mousePos) > maxDistance){
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDistance;
            }
            else
                rb.position = mousePos;
        }
    }

    private void OnMouseDown()
    {

        if (Spawn.ballCount > 0)
        {
            isPressed = true;
            rb.isKinematic = true;
        }
        showFloatingText();
    }
    public void showFloatingText()
    {

        GameObject floater = Instantiate(Resources.Load("floatingText", typeof(GameObject)), transform.position, Quaternion.identity, transform) as GameObject;
        floater.GetComponent<TextMesh>().text = Spawn.ballCount.ToString();


    }
    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Unhook());
    }

    IEnumerator Unhook (){

        yield return new WaitForSeconds(timer);

        GetComponent<SpringJoint2D>().enabled = false;

        this.enabled = false;

        yield return new WaitForSeconds(2f);
        
        Spawn.ballCount--;

        Destroy(gameObject);
        Spawn.count = 0;
        if (nextBall != null && Spawn.ballCount > 0)
        {
            nextBall.SetActive(true);
        }
        if (nextBall = null)
        {
            deactivateAnchor = true;
        }







    }

}
