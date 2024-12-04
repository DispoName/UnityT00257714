using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMovement : MonoBehaviour
{
    Animator characterAnimation;
    // Start is called before the first frame update
    void Start()
    {
        characterAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float turnSpeed = 150;
        characterAnimation.SetBool("isWalking", false);
        characterAnimation.SetBool("isRunning", false);
        characterAnimation.SetBool("isBack", false);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward  * Time.deltaTime;
            characterAnimation.SetBool("isWalking", true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += transform.forward * Time.deltaTime * 5;
                characterAnimation.SetBool("isRunning", true);

            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
            characterAnimation.SetBool("isBack", true);
        }
    }
}
