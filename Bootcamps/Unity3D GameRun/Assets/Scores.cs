using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text ScorePlayer1;
    public Text ScorePlayer2;
    int red = 0;
    int blue = 0;

    private void Start()
    {
        ScorePlayer2.text = "Blue: " + blue;
        ScorePlayer1.text = "Red: " + red;
    }

    public void pontos(string cor)
    {
        if (cor == "red")
        {
            blue = blue + 1;
            ScorePlayer2.text = "Blue: " + blue;
        }

        if (cor == "blue")
        {
            red = red + 1;
            ScorePlayer1.text = "Red: " + red;
        }
    }
}
    