using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int score;
    private TextMeshProUGUI scoreText;

    public GameObject scoreTMP;

    void Start()
    {
        score = 0;
        scoreText = scoreTMP.GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }



    void Update()
    {
        
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
        scoreText.text = "Score: " + score;
    }
}
