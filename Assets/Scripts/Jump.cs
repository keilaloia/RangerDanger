//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Jump : MonoBehaviour {


//    public float Epower = 5.0f;
//    public float radius = 1.0f;
//    public bool isGrounded = false;

//    private void OnCollisionStay(Collision collision)
//    {
//        isGrounded = true;
//    }

//    private void OnCollisionExit(Collision collision)
//    {
//        isGrounded = false;
//    }
//    // Use this for initialization
//    void Start()
//    {
//        Vector2 explosionPos = transform.position;

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Rigidbody2D rbody = GetComponent<Rigidbody2D>();

//        if (Input.GetKeyDown("space") && isGrounded == true)
//        {
//            Debug.Log("please");
//            rbody.


//        }
//    }
//}
