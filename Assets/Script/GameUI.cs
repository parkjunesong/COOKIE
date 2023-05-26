using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public GameObject gameOverUI;
    public Slider hpBarUI;
    public Text scoreText;

    void Start()
    {
        gameOverUI.SetActive(false);

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);

        Data.Score += 10f;
        Data.Hp -= 0.3f;
        hpBarUI.value = Data.Hp / Data.MainChara.HP;
        scoreText.text = "Score: " + Data.Score;

        StartCoroutine(Timer());
    }

    public void GameOver()
    {
        hpBarUI.gameObject.SetActive(false); // 체력바 UI 비활성화
        scoreText.gameObject.SetActive(false); // 점수 UI 비활성화
        gameOverUI.SetActive(true); // 게임 오버 창 띄우기
    }
}
