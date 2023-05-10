using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mm : MonoBehaviour
{
    public GameObject a; 
    public void setChara()
    {
        a.GetComponent<Image>().sprite = Data.MainChara.Standing;
    }
}
