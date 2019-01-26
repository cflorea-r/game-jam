using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

   

    int player1Score, player2Score, player3Score, player4Score;
    public float timeLeft = 120;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeText.text = ((int)timeLeft).ToString();
        }
        if (timeLeft < 0)
        {
            timeText.text = "Game over";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
    public void AddScore(int playerNumber)
    {
        switch (playerNumber)
        {
            case 1:
                player1Score++;
                break;
            case 2:
                player2Score++;
                break;
            case 3:
                player3Score++;
                break;
            case 4:
                player4Score++;
                break;
        }
    }

    public void ReduceScore(int playerNumber)
    {
        switch (playerNumber)
        {
            case 1:
                player1Score--;
                break;
            case 2:
                player2Score--;
                break;
            case 3:
                player3Score--;
                break;
            case 4:
                player4Score--;
                break;
        }
    }

    public void printScores()
    {
        Debug.Log("player1score: " + player1Score);
        Debug.Log("player2score: " + player2Score);
        Debug.Log("player3score: " + player3Score);
        Debug.Log("player4score: " + player4Score);
    }
}
