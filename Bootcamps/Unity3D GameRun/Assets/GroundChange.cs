using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChange : MonoBehaviour
{
    int numCol;
    
    bool isWaiting;
    public Renderer rend;
    public Material material1;
    public Material material2;
    public Material material3;
    public GameObject partido;


    // Start is called before the first frame update
    void Start()
    {
        numCol = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && !isWaiting)
        {
            StartCoroutine(change());
        }
    }

    IEnumerator change()
    {
        numCol++;
        if (numCol == 1)
        {
            isWaiting = true;
            rend.material = material1;
            yield return new WaitForSeconds(1);
            isWaiting = false;
        }

        if(numCol == 2)
        {
            isWaiting = true;
            rend.material = material2;
            yield return new WaitForSeconds(1);
            isWaiting = false;
        }

        if(numCol == 3)
        {
            isWaiting = true;
            rend.material = material3;
            yield return new WaitForSeconds(1);
            isWaiting = false;
        }

        if(numCol == 4)
        {
            Instantiate(partido, this.gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
