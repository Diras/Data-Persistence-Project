using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private int score;
    

    public int bestScore;
    public Text BestScore;
    public Text Score;
    public string bestPlayerName;
    public string playerName;
    

    void Start()
    {
        playerName = PlayerPrefs.GetString("Name");
        bestPlayerName = PlayerPrefs.GetString("BestPlayerName");
        

        score = PlayerPrefs.GetInt("m_Points");
        Score.text = $"Score : {score}";

        bestScore = PlayerPrefs.GetInt("bestScore");
        if (bestScore < score)
        {
            bestScore = score;
            bestPlayerName = playerName;
        }
        PlayerPrefs.SetString("BestPlayerName", bestPlayerName);
        PlayerPrefs.SetInt("bestScore", bestScore);


        BestScore.text = $"Best Score : {bestPlayerName} : {bestScore}";

    }
    
   
}
