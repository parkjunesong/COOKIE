using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public GameObject gameOverUI;
    public Slider hpBarUI;
    public Text scoreText;
    public Text hpText;
    public GameObject pauseButton;
    

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
        hpText.text = (int)Data.Hp + "";

        if (Data.Hp <= 0)
        {
            GameOver();
            Time.timeScale = 0f; // ���� �Ͻ� ����
            yield break; // ���� ���� ��Ȳ������ �߰��� Ÿ�̸Ӹ� ������ �ʿ䰡 �����Ƿ� �ڷ�ƾ�� �����մϴ�.
        }

        StartCoroutine(Timer());
    }

    public void GameOver()
    {
        hpBarUI.gameObject.SetActive(false); // ü�¹� UI ��Ȱ��ȭ
        scoreText.gameObject.SetActive(false); // ���� UI ��Ȱ��ȭ
        pauseButton.SetActive(false);
        gameOverUI.SetActive(true); // ���� ���� â ����
    }
}
