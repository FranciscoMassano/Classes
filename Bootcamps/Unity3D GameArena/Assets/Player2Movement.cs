using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public Renderer rend;
    public Rigidbody body;
    public float speed;
    public ParticleSystem explosion;
    public GameManager manager;
    public bool isDying;

    // Start is called before the first frame update
    void Start()
    {
        isDying = false;
    }

    private void Update()
    {
        if (transform.position.y < -20 && isDying == false)
        {
            isDying = true;
            rend.enabled = false;
            body.constraints = RigidbodyConstraints.FreezeAll;
            explosion.Play();
            manager.pontos1 = manager.pontos1 + 1;
            manager.StartCoroutine("restart");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            body.AddForce(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
