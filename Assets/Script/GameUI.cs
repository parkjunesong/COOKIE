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
            Time.timeScale = 0f; // 게임 일시 정지
            yield break; // 게임 오버 상황에서는 추가로 타이머를 실행할 필요가 없으므로 코루틴을 종료합니다.
        }

        StartCoroutine(Timer());
    }

    public void GameOver()
    {
        hpBarUI.gameObject.SetActive(false); // 체력바 UI 비활성화
        scoreText.gameObject.SetActive(false); // 점수 UI 비활성화
        pauseButton.SetActive(false);
        gameOverUI.SetActive(true); // 게임 오버 창 띄우기
        finalScoreText.text = "Score: " + Data.Score; // 최종Score 표시
        finalScoreText.gameObject.SetActive(true); // finalScoreText 활성화
    }

    public void inputName()
    {
        string name = "유저";
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
