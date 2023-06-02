using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mm : MonoBehaviour
{
    public GameObject charaimage;
    public GameObject treasureimage;
    public void setChara()
    {
        charaimage.GetComponent<Image>().sprite = Data.MainChara.Standing;
    }
    public void setTreasure()
    {
        treasureimage.GetComponent<Image>().sprite = Data.SelectedTreasure.Standing;
    }
}
