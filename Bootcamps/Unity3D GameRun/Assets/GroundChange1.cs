using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChange1 : MonoBehaviour
{
    bool isWorking;

    public int fase;
    public Renderer rend;
    public Material verde;
    public Material amarelo;
    public Material vermelho;
    public GameObject brokenGround;


    // Start is called before the first frame update
    void Start()
    {
        fase = 0;
        isWorking = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(isWorking == false)
            {
                StartCoroutine(Change());
            }
        }
    }

    IEnumerator Change()
    {
         isWorking = true;
         fase = fase + 1;
         if (fase == 1)
         {
            rend.material = verde;
            yield return new WaitForSeconds(1);
         }

         if (fase == 2)
         {
            rend.material = amarelo;
            yield return new WaitForSeconds(1);
         }

         if (fase == 3)
         {
            rend.material = vermelho;
            yield return new WaitForSeconds(2);
            Instantiate(brokenGround, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
         }

        isWorking = false;
    }
}
