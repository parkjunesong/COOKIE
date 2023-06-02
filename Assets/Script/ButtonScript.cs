using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject[] Scene = new GameObject[3];
    public GameObject pause;
    public GameObject resume;
    GameObject audio;

    void Start()
    {
        audio = GameObject.Find("Audio");
    }
    public void GameStart()
    {
        if (Data.MainChara.Name != "None")
        {
            audio.GetComponent<AudioManager>()._play(1); // n초 대기시켜서 사운드 들리게
            SceneManager.LoadScene("play");
        }           
    }
    public void Goto_select()
    {
        Scene[0].SetActive(false);
        Scene[1].SetActive(true);
        audio.GetComponent<AudioManager>()._play(0);
    }
    public void Back_main()
    {
        Scene[1].SetActive(false);
        Scene[2].SetActive(false);
        Scene[0].SetActive(true);
        audio.GetComponent<AudioManager>()._play(0);
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
        audio.GetComponent<AudioManager>()._play(0);
    }
    public void Pause()
    {
        Time.timeScale = 0f; //정지
        pause.SetActive(false);
        resume.SetActive(true);
        audio.GetComponent<AudioManager>()._play(0);
    }
    public void Resume()
    {
        Time.timeScale = 1f; //시작
        pause.SetActive(true);
        resume.SetActive(false);
        audio.GetComponent<AudioManager>()._play(0);
    }
}
