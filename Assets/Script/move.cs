using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    int jc = 0;
    bool isBeat = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {           
            if (jc == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 12f, ForceMode2D.Impulse);
                jc++;
            }
            else if (jc == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 6f, ForceMode2D.Impulse);
                jc++;
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
                Debug.Log("Ãæµ¹");
                Data.Hp -= 10;

                isBeat = true;
                StartCoroutine("UnBeatTime");
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
