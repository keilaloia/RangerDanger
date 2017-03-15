using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaste : MonoBehaviour
{

    public float floatHeight;
    public float liftForce;
    public float damping;
    public Rigidbody2D rb2D;
    private PolygonCollider2D coll;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }
    void FixedUpdate()
    {
        //check all objects between player position and infinity
        RaycastHit2D[] hit = Physics2D.RaycastAll(transform.position, -Vector2.up, floatHeight);
        float minDist = Mathf.Infinity;
        //pick closest object
        for (int i = 0; i < hit.Length; i++)
        {
            if (hit[i].collider != null && hit[i].collider != coll)
            {
                float distance = Mathf.Abs(hit[i].point.y - transform.position.y);
                if(distance < minDist)
                {
                    minDist = distance;
                }
            }
        }
        //math for closest found collision
        if (minDist < Mathf.Infinity)
        {

            float heightError = floatHeight - minDist;
            float force = liftForce * heightError - rb2D.velocity.y * damping;
            rb2D.AddForce(Vector3.up * force);
            Debug.Log("hit " + force + " " + heightError + " " + minDist);
        }
    }
}