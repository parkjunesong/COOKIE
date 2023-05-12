<<<<<<< HEAD
/*using System.Collections;
using System.Collection.Generic;
=======
using System.Collections;
using System.Collections.Generic;
>>>>>>> 83c9ec97aa86347ff704ccb38b22ec3bb42146bd
using UnityEngine;
using UnityEngine.UI;

public class HpGaugeEff : MonoBehaviour
{
    public Image img;
    public GameObject eff;
    public float value = 2;
<<<<<<< HEAD
    private float width;  //이미지의 길이(체력바의 길이)
=======
    private float width;  
>>>>>>> 83c9ec97aa86347ff704ccb38b22ec3bb42146bd
    
    void Start()
    {
        this.width = this.img.GetComponent<RectTransform>().rect.width;
    }
     
    void Update()
    {
<<<<<<< HEAD
        var pos = this.eff.transform.localPosition; //pos는 이펙터의 위치로 변수 넣어줌
        pos.x = this.img.fillAmount * this.width -12 -2; //12: eff의 넓이의 반, 2: offset #pos.x의 값을 이미지의 필어마운트(줄어드는 값) * width(체력바의 총 길이) -12(이펙트의 길이 반) -2 를 해준다. (Img의 필어마운트를 조절하면 체력바가 줄어듦)
=======
        var pos = this.eff.transform.localPosition; 
        pos.x = this.img.fillAmount * this.width -12 -2;  
>>>>>>> 83c9ec97aa86347ff704ccb38b22ec3bb42146bd
        this.eff.transform.localPosition = pos;
    }
}*/