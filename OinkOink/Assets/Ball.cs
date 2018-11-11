using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private bool isPressed = false;

    public float timer = 0.15f;

    public float maxDistance = 2.0f;

    public Rigidbody2D hook;

    public Rigidbody2D rb;

    private void Update()
    {

        if (isPressed){

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
       
        isPressed = true;
        rb.isKinematic = true;
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
    }

}
