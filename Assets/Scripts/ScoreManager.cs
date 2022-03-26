using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public Text scoreText;

    void Start()
    {
        
    }
    public void ScoreUpdate(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("Score :" + score);
    }
   
}
