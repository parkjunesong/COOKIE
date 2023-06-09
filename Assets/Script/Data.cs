using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityData
{
    public string Name;
    public string Text;
    public int HP;
    public float HP_P;
    public float HP_M;
    public float Score;
    public Sprite Standing;
    public RuntimeAnimatorController Ani;

    public AbilityData()
    {
        Name = "None";
        Text = "";
        HP = 0;
        HP_P = 0;
        HP_M = 0;
        Score = 0;     
        Standing = Resources.Load("Chara/default", typeof(Sprite)) as Sprite;
        //Ani =
    }
    public AbilityData(string _name, string _text, int _hp, float _hpp, float _hpm, float _score, Sprite _standing, RuntimeAnimatorController _ani)
    {
        Name = _name;
        Text = _text;
        HP = _hp;
        HP_P = _hpp;
        HP_M = _hpm;
        Score = _score;
        Standing = _standing;
        Ani = _ani;
    }
}

public class Data : MonoBehaviour
{
    public static AbilityData MainChara = new AbilityData();
    public static AbilityData SelectedTreasure = new AbilityData();
    public static float Speed;
    public static float Score;
    public static float Hp;
    GameObject audio;

    void Start()
    {
        Speed = 6f;
        Score = 0;
        MainChara = new AbilityData(MainChara.Name, MainChara.Text, MainChara.HP + SelectedTreasure.HP, MainChara.HP_P + SelectedTreasure.HP_P, MainChara.HP_M + SelectedTreasure.HP_M, MainChara.Score + SelectedTreasure.Score, MainChara.Standing, MainChara.Ani);
        Hp = MainChara.HP;
        GameObject.Find("Player").GetComponent<Animator>().runtimeAnimatorController = MainChara.Ani;

        audio = GameObject.Find("Audio");       
        int ran = Random.Range(5, 8) + 1;
        audio.GetComponent<AudioManager>()._loop(ran);
            
    }
}
