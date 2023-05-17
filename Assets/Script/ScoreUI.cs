using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    public float scoreIncreaseInterval = 2f; // ���� ���� ����(��)
    public int minScoreIncreaseAmount = 5; // �ּ� ���� ������
    public int maxScoreIncreaseAmount = 20; // �ִ� ���� ������

    private int score = 0;
    private float timer = 0f;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void Update()
    {
        // �ð��� �带���� ���� ����
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
