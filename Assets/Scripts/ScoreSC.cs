using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSC : MonoBehaviour
{
    private  Text Score;
    private  int score;
    private  int Bestscore;
    public Text BestScoretxt;
    void Start()
    {
        Score = GetComponent<Text>();
        Bestscore = PlayerPrefs.GetInt("Score");
        BestScoretxt.text = "Best Score : " + Bestscore;
        score = 0;
        Score.text = "" + score;
    }
    public  void UpdateScore()
    {
        score++;
        Score.text = "" + score;

        if (score > PlayerPrefs.GetInt("Score")) {
           
                PlayerPrefs.SetInt("Score",score);
            Bestscore = score;
           BestScoretxt.text = "Best Score : " + Bestscore;
        }
    }
    
}
