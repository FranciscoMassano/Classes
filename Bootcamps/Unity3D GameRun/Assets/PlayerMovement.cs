using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody body;
    public int speed;
    public int jumpForce;
    public KeyCode forward;
    public KeyCode left;
    public KeyCode right;
    public KeyCode back;
    public KeyCode jump;
    bool isJumping;


    // Start is called before the first frame update
    void Start()
    {
        isJumping = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(forward))
        {
            body.AddForce(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(left))
        {
            body.AddForce(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(right))
        {
            body.AddForce(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(back))
        {
            body.AddForce(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(jump) && !isJumping)
        {
            body.AddForce(Vector3.up * jumpForce);
            isJumping = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
