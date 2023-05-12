using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpGaugeEff : MonoBehaviour
{
    public Image img;
    public GameObject eff;
    public float value = 2;
    private float width;  
    
    void Start()
    {
        this.width = this.img.GetComponent<RectTransform>().rect.width;
    }
     
    void Update()
    {
        var pos = this.eff.transform.localPosition; 
        pos.x = this.img.fillAmount * this.width -12 -2;  
        this.eff.transform.localPosition = pos;
    }
}
