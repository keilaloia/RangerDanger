using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaste : MonoBehaviour
{

    public float floatHeight;
    public float liftForce;
    public float damping;
    public Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;
            float force = liftForce * heightError - rb2D.velocity.y * damping;
            rb2D.AddForce(Vector3.up * force);
            Debug.Log("hit");
        }
    }
}