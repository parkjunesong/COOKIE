using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameUI : MonoBehaviour
{
    public GameObject gameOverUI;
    public Slider hpBarUI;
    public Text scoreText;
    public Text hpText;
    public GameObject pauseButton;
    public Text finalScoreText;
    public InputField Rname;
    public GameObject gotomain;


    void Start()
    {
        gameOverUI.SetActive(false);
        finalScoreText.gameObject.SetActive(false);
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
        finalScoreText.text = "Score: " + Data.Score; // ����Score ǥ��
        finalScoreText.gameObject.SetActive(true); // finalScoreText Ȱ��ȭ
    }

    public void inputName()
    {
        string name = "����";
        name = Rname.text;

        int n = 0;
        while (true)
        {
            if (File.Exists("gamelog/" + "log_" + n.ToString() + ".txt") == false)
            {
                var file = File.CreateText("gamelog/" + "log_" + n.ToString() + ".txt");
                StreamWriter sw = file;
                sw.WriteLine(Data.MainChara.Name + "," + Data.SelectedTreasure.Name + "," + Data.Score + "," + name);
                sw.Flush();
                sw.Close();
                file.Close();
                break;
            }
            else n++;
        }

        gotomain.SetActive(true);
    }

}
