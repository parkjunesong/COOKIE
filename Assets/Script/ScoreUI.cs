using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    public float scoreIncreaseInterval = 2f; // 점수 증가 간격(초)
    public int minScoreIncreaseAmount = 5; // 최소 점수 증가량
    public int maxScoreIncreaseAmount = 20; // 최대 점수 증가량

    private int score = 0;
    private float timer = 0f;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void Update()
    {
        // 시간이 흐를수록 점수 증가
        timer += Time.deltaTime;
        if (timer >= scoreIncreaseInterval)
        {
            int increaseAmount = Random.Range(minScoreIncreaseAmount, maxScoreIncreaseAmount + 1);
            IncreaseScore(increaseAmount);
            timer = 0f;
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
