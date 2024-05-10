using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{
    public Text scoreText;

    public static int scoreCount;



    private void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    
}
