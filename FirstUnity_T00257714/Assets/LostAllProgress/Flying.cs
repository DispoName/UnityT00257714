using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    Rigidbody rb;
    float thrust = 5;
    float pitch = 30;
    float pitchSides = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(thrust * transform.up);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.back, pitch * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.right, pitchSides * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.left, pitchSides * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.forward, pitch * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            // Roll Left
            transform.Rotate(Vector3.up, pitchSides * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            // Roll Left
            transform.Rotate(Vector3.down, pitchSides * Time.deltaTime);
        }
    }
}
