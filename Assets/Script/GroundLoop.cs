using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    public float startPosition;
    public float endPosition;
    public float speed;

    void FixedUpdate()
    {
        transform.Translate(-1 * (Data.Speed / 5) * speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= endPosition)
        {
            transform.Translate(-1 * (endPosition - startPosition), 0, 0);
        }
    }
}
