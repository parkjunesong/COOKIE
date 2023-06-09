using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class RankingData
{
    public string Chara { get; set; }
    public string Treasure { get; set; }
    public int Score { get; set; }
    public string Name { get; set; }
}

public class mm : MonoBehaviour
{
    public GameObject charaimage;
    public GameObject treasureimage;
    GameObject audio;



    void Start()
    {
        audio = GameObject.Find("Audio");
        audio.GetComponent<AudioManager>()._play(2);

        int n = 0;
        List<RankingData> Rdata = new List<RankingData>();
        while (true)
        {
            if (File.Exists("gamelog/" + "log_" + n.ToString() + ".txt") == false) break;
            else
            {
                var file = File.OpenText("gamelog/" + "log_" + n.ToString() + ".txt");
                StreamReader sr = file;

                string data_String = sr.ReadLine();
                var data_values = data_String.Split(',');
                Rdata.Add(new RankingData {Chara = data_values[0], Treasure = data_values[1], Score = int.Parse(data_values[2]), Name = data_values[3] });                                
                n++;
            }
        }
        Rdata.Sort((x, y) => {return y.Score.CompareTo(x.Score);});
        for (int i = 0; i < 10; i++)
        {
            GameObject target = GameObject.Find("r" + i.ToString());
            target.SetActive(false);
            if (i<n)            
            {
                target.SetActive(true);

                string chara = Rdata[i].Chara;
                string treasure = Rdata[i].Treasure;
                int score = Rdata[i].Score;
                string name = Rdata[i].Name;
                target.transform.GetChild(0).GetComponent<Text>().text = (i + 1).ToString();
                target.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load("Chara/" + chara, typeof(Sprite)) as Sprite;
                if (treasure != "None") target.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load("Treasure/" + treasure, typeof(Sprite)) as Sprite;
                target.transform.GetChild(3).GetComponent<Text>().text = name + ": " + score;
            }  
        }
    }
    public void setChara()
    {
        charaimage.GetComponent<Image>().sprite = Data.MainChara.Standing;
    }
    public void setTreasure()
    {
        treasureimage.GetComponent<Image>().sprite = Data.SelectedTreasure.Standing;
    }
}
