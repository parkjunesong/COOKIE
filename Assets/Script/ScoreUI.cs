using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    public float scoreIncreaseInterval = 1f; // ���� ���� ����(��)
    public int minScoreIncreaseAmount = 5; // �ּ� ���� ������
    public int maxScoreIncreaseAmount = 20; // �ִ� ���� ������
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
        scoreText.gameObject.SetActive(false); // ���� UI ��Ȱ��ȭ
        GameOverPanel.SetActive(true); // ���� ���� �г� ��Ȱ��ȭ
    }
}
