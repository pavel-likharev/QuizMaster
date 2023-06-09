using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    GameOver gameOver;


    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        gameOver = FindObjectOfType<GameOver>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);

            gameOver.ShowFinalScore();
            quiz.isComplete = false;
        }
    }

    public void OnRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
