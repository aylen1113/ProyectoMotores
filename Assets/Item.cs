using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Text scoreText;
    private int score = 0; 
    private static int totalItems; 

    public static Action OnCollected { get; internal set; }

    private void Start()
    {
        totalItems++; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Score scoreScript = FindObjectOfType<Score>();
            if (scoreScript != null)
            {
                scoreScript.CollectObject();
            }
            if (score == 9)
             
            {
            SceneManager.LoadScene(1);
        }
    }
}
}





