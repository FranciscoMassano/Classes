using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
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

    // Update is called once per frame
    private void Update()
    {
        if(transform.position.y < -20 && isDying == false)
        {
            isDying = true;
            rend.enabled = false;
            body.constraints = RigidbodyConstraints.FreezeAll;
            explosion.Play();
            manager.pontos2 = manager.pontos2 + 1;
            manager.StartCoroutine("restart");
        }
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(Vector3.back * speed * Time.deltaTime);
        }
    }



}
