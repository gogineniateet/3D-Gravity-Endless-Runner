using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public Text scoreText;

 
    public void ScoreUpdate(int scoreValue)
    {
        scoreText.text = score.ToString();
        score =  scoreValue;
        //Debug.Log("Score :" + score);
    }
   
}
