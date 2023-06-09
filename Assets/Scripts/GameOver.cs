using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    [SerializeField] TextMeshProUGUI finalScoreText;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        Debug.Log("dsfsdfsdfsf");
        finalScoreText.text = $"Congratulations!\nYou scored {scoreKeeper.CalculateScore()}%";

    }
}
