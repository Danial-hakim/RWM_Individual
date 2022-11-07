using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTimer : MonoBehaviour
{
    public PlayerScript player;
    public TextMeshProUGUI scoreText;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.SetText("Score: " + score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.alive)
        {
            Debug.Log("Player not alive");
        }
        else
        {
            Debug.Log("Player alive");
            score += Time.deltaTime; // Adds 1 to score every second;
            scoreText.text = ("Score: " + Mathf.RoundToInt(score).ToString()); // Rounds the score to an INT and displays it
        }
    }
}
