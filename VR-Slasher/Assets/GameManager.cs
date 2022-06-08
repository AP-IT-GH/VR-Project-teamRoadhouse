using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int amountOfCans = 9;
    public Text gamesWonText;

    private bool ballGameWon;
    private int gamesWon;
    private int currentScore;

    void Start()
    {
        gamesWon = 0;
        currentScore = 0;
    }

    void Update()
    {
        currentScore = CanPointsManager.instance.points;
        if (currentScore == amountOfCans)
        {
            if (!ballGameWon)
            {
                ballGameWon = true;
                gamesWon++;
                gamesWonText.text = "Games won: " + gamesWon;
            }
        }
    }
}