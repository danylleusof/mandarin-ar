using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{

    public float timeLeft = 60.0f;
    Text TimeText, FinalScore;
    public GameObject Quiz, GameOver;

    void Update()
    {
        timeLeft -= UnityEngine.Time.deltaTime;
        TimeText = GameObject.Find("Timer").GetComponent<Text>();
        TimeText.text = "Time Left: " + timeLeft.ToString("0");
        if (timeLeft < 0)
        {
            Quiz.gameObject.SetActive(false);
            GameOver.gameObject.SetActive(true);
            FinalScore = GameObject.Find("FinalScore").GetComponent<Text>();
            FinalScore.text = "Score: " + ScoringSystem.scorePoints;
        }
    }
}