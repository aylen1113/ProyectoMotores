using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText; 
    private int score = 0;

    private void Start()
    {
        UpdateScoreText();
    }

    
    public void CollectObject()
    {
        score ++; 
        UpdateScoreText(); 
    }

    
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    internal int GetScore()
    {
        throw new NotImplementedException();
    }
}


