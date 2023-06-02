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

    public AbilityData()
    {
        Name = "None";
        Text = "";
        HP = 0;
        HP_P = 0;
        HP_M = 0;
        Score = 0;     
        Standing = Resources.Load("Chara/default", typeof(Sprite)) as Sprite;
    }
    public AbilityData(string _name, string _text, int _hp, float _hpp, float _hpm, float _score, Sprite _standing)
    {
        Name = _name;
        Text = _text;
        HP = _hp;
        HP_P = _hpp;
        HP_M = _hpm;
        Score = _score;
        Standing = _standing;
    }
}

public class Data : MonoBehaviour
{
    public static AbilityData MainChara;
    public static AbilityData SelectedTreasure;
    public static float Speed;
    public static float Score;
    public static float Hp;

    void Start()
    {
        Speed = 7f;
        Score = 0;

        MainChara = new AbilityData(MainChara.Name, MainChara.Text, MainChara.HP + SelectedTreasure.HP, MainChara.HP_P + SelectedTreasure.HP_P, MainChara.HP_M + SelectedTreasure.HP_M, MainChara.Score + SelectedTreasure.Score, MainChara.Standing);
        Hp = MainChara.HP;
    }
}
