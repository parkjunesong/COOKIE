using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    int jc = 0;
    bool isBeat = false;
    bool isSlide = false;
    GameObject audio;

    void Start()
    {
        audio = GameObject.Find("Audio");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSlide)
        {           
            if (jc == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 12f, ForceMode2D.Impulse);
                jc++;
                audio.GetComponent<AudioManager>()._play(1);
            }
            else if (jc == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 6f, ForceMode2D.Impulse);
                jc++;
                audio.GetComponent<AudioManager>()._play(1);
            }          
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if(jc == 0)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.8f, gameObject.transform.position.z);
                gameObject.transform.localScale = new Vector3(1, 0.5f, 1);
                isSlide = true;
                audio.GetComponent<AudioManager>()._play(2);
            }          
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            if(isSlide == true)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.8f, gameObject.transform.position.z);
                gameObject.transform.localScale = new Vector3(1, 1, 1);
                isSlide = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jc = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            if (isBeat == false)
            {
                Data.Hp -= 10 - Data.MainChara.HP_M; // 데미지 표시 ui 필요할지도 
                audio.GetComponent<AudioManager>()._play(3);
                isBeat = true;
                StartCoroutine("UnBeatTime");
            }
        }
        if (collision.gameObject.tag == "Item")
        {
            if (collision.GetComponent<item>().idata.Name == "HP포션(소)")
            {
                audio.GetComponent<AudioManager>()._play(4);
                Data.Hp += collision.GetComponent<item>().idata.HP;
                if (Data.Hp >= Data.MainChara.HP) Data.Hp = Data.MainChara.HP;
            }


        }
    }   

    IEnumerator UnBeatTime()
    {
        for (int i = 0; i < 20; ++i)
        {
            if (i % 2 == 0)
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 90);
            else
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 180);

            yield return new WaitForSeconds(0.1f);
        }

        GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);

        isBeat = false;

        yield return null;
    }
}
