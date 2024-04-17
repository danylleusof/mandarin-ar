using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public static int scorePoints = 0;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Scoreboard").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scorePoints;
    }
}
