using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    public int pontos1;
    public int pontos2;

    public Text score1;
    public Text score2;

    private void Start()
    {
        pontos1 = 0;
        pontos2 = 0;
    }

    public IEnumerator restart()
    {
        score1.text = "Player1: " + pontos1;
        score2.text = "Player2: " + pontos2;

        yield return new WaitForSeconds(1.9f);
        player1.transform.position = new Vector3(-7, 3, 0);
        player1.GetComponent<MeshRenderer>().enabled = true;
        player1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        player1.GetComponent<Player1Movement>().isDying = false;

        player2.transform.position = new Vector3(7, 3, 0);
        player2.GetComponent<MeshRenderer>().enabled = true;
        player2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        player2.GetComponent<Player2Movement>().isDying = false;


    }
}
