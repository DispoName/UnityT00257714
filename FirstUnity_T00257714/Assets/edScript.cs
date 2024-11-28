using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edScript : MonoBehaviour
{
    public GameObject giftCloneTemplate;
    float turningSpeed = 100;
    Animator edsAnimator;
    float jumpHeight = 30;
    float walkingSpeed = 1;
    float runningMultiplier = 3;

    // Start is called before the first frame update
    void Start()
    {
        edsAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        edsAnimator.SetBool("IsWalking", false);
        edsAnimator.SetBool("isBackward", false);
        edsAnimator.SetBool("IsRunning", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            edsAnimator.SetBool("IsWalking", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
            edsAnimator.SetBool("isBackward", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }



        if (Input.GetKey(KeyCode.LeftShift))
        {
            edsAnimator.SetBool("IsRunning", true);
        }
        else
        {
            edsAnimator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(giftCloneTemplate, transform.position, transform.rotation);
        }
    }
}
