using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketScript : MonoBehaviour
{

    float turningSpeed = 100;
    float thrustValue = 5;
    float gravity = 2;
    Rigidbody rb;
    Vector3 velocity, acceleration;

    // Start is called before the first frame update
    void Start()
    {
     
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //acceleration = Vector3.zero;
        //
        //acceleration += gravity * Vector3.down;

        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += transform.up * Time.deltaTime;
            //acceleration += thrustValue * transform.up;
            rb.AddForce(thrustValue * transform.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Roll Left
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Roll right
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // pitch up
            transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // pitch down
            transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);
        }

        transform.Rotate(Vector3.up, 
            Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime);
        transform.Rotate(Vector3.down, 
            Input.GetAxis("Vertical") * turningSpeed * Time.deltaTime);

        //Roll using mouse

        // velocity += acceleration * Time.deltaTime;
        // transform.position += velocity * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
    }
}
