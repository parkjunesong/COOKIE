using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject[] Scene = new GameObject[3];
    public GameObject pause;
    public GameObject resume;
  
    public void GameStart()
    {
        if (Data.MainChara.Name != "None")
            SceneManager.LoadScene("play");
    }
    public void Goto_select()
    {
        Scene[0].SetActive(false);
        Scene[1].SetActive(true);
    }
    public void Back_main()
    {
        Scene[1].SetActive(false);
        Scene[2].SetActive(false);
        Scene[0].SetActive(true);
    }
    public void Goto_main()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1f; //재시작
    }
    public void Goto_treasure()
    {
        Scene[0].SetActive(false);
        Scene[2].SetActive(true);
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("play");
        Time.timeScale = 1f; //재시작
        Data.Hp = Data.MainChara.HP; //체력리셋
        Data.Score = 0f; //점수리셋
    }
    public void Pause()
    {
        Time.timeScale = 0f; //정지
        pause.SetActive(false);
        resume.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1f; //시작
        pause.SetActive(true);
        resume.SetActive(false);
    }
}
