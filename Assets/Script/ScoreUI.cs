using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    public float scoreIncreaseInterval = 1f; // 점수 증가 간격(초)
    public int minScoreIncreaseAmount = 5; // 최소 점수 증가량
    public int maxScoreIncreaseAmount = 20; // 최대 점수 증가량
    public GameObject GameOverPanel;

    private int score = 0;
    private float timer = 0f;
    private bool isGameOver = false;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void Update()
    {
        if (isGameOver)
        {
            return;
        }

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

    public void GameOver()
    {
        isGameOver = true;
        scoreText.gameObject.SetActive(false); // 점수 UI 비활성화
        GameOverPanel.SetActive(true); // 게임 오버 패널 비활성화
    }
}
