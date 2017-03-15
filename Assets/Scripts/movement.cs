using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    //movement variables
    private float movex;
   // private float movey;
    public float movespeed;

    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");



        Vector2 input = new Vector2(horizontal, 0);
        input *= movespeed;

        Rigidbody2D rbody = GetComponent<Rigidbody2D>();

        rbody.AddForce(input);
    }
}
