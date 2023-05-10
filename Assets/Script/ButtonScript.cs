using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject[] Scene = new GameObject[2];
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
        Scene[0].SetActive(true);
    }
}
