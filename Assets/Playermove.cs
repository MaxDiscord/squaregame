using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float forwardSpeed;
    public float sideSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Variables Defined");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(-forwardSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey("a"))
        {
            rb.AddForce(0,0,sideSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideSpeed * Time.deltaTime);
        }
    }
}
