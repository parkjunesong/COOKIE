using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTreasure : MonoBehaviour
{
    public TreasureData TData;

    void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Text>().text = TData.Name;
        gameObject.transform.GetChild(1).GetComponent<Image>().sprite = TData.Image;
        gameObject.transform.GetChild(4).GetComponent<Text>().text = TData.Ability + "";
        gameObject.transform.GetChild(5).GetComponent<Text>().text = TData.Text;
    }
    public void Select()
    {
        Data.SelectedTreasure = new AbilityData(TData.Name, TData.Text, TData.HP, TData.HP_P, TData.HP_M, TData.Score, TData.Image, null);
        GameObject.Find("Master").GetComponent<mm>().setTreasure();
    }
}