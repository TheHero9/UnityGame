using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 1000f;
    public float upsideForce = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce( 0, 0, sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space) && transform.position.y == 1f)
        {
            rb.AddForce(0, upsideForce, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(0, -upsideForce * Time.deltaTime, 0);
        }
    }

    void OnMouseDown()
    {
        rb.AddForce(0, 0, forwardForce);
    }
}
