﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class victoryScript : MonoBehaviour
{
    Button button;
    [SerializeField]
    Text player1, player2, player3, player4;
    [SerializeField]
    Text winner;
    ScoreScript scoreScript;
    public List<int> scores;


    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.Find("Score").GetComponent<ScoreScript>();
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
        player1.text = "Player1 Score: " + scoreScript.player1Score;
        player2.text = "Player2 Score: " + scoreScript.player2Score;
        player3.text = "Player3 Score: " + scoreScript.player3Score;
        player4.text = "Player4 Score: " + scoreScript.player4Score;

        scores.Add(scoreScript.player1Score);
        scores.Add(scoreScript.player2Score);
        scores.Add(scoreScript.player3Score);
        scores.Add(scoreScript.player4Score);

        scores.Sort();

        if(scores[0] == scoreScript.player1Score)
        {
            winner.text = "Player1 Wins";
        }
        else if (scores[0] == scoreScript.player2Score)
        {
            winner.text = "Player2 Wins";
        }
        else if (scores[0] == scoreScript.player3Score)
        {
            winner.text = "Player3 Wins";
        }
        else if (scores[0] == scoreScript.player3Score)
        {
            winner.text = "Player4 Wins";
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
