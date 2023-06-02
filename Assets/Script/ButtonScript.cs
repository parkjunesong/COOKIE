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
        Time.timeScale = 1f; //�����
    }
    public void Goto_treasure()
    {
        Scene[0].SetActive(false);
        Scene[2].SetActive(true);
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("play");
        Time.timeScale = 1f; //�����
        Data.Hp = Data.MainChara.HP; //ü�¸���
        Data.Score = 0f; //��������
    }
    public void Pause()
    {
        Time.timeScale = 0f; //����
        pause.SetActive(false);
        resume.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1f; //����
        pause.SetActive(true);
        resume.SetActive(false);
    }
}
