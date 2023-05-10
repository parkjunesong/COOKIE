using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChara : MonoBehaviour
{
    public CharaData CData;

    void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Text>().text = CData.Name;
        gameObject.transform.GetChild(1).GetComponent<Image>().sprite = CData.Standing;
        gameObject.transform.GetChild(4).GetComponent<Text>().text = CData.HP + "";
        gameObject.transform.GetChild(7).GetComponent<Text>().text = CData.Text;
    }
    public void Select()
    {
        Data.MainChara = new CharaSelectData(CData.Name, CData.Text, CData.HP, CData.HP_P, CData.HP_M, CData.Score, CData.Standing);
        GameObject.Find("Master").GetComponent<mm>().setChara();
    }
}
