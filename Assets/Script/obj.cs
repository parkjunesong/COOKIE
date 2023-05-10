using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(-1 * Data.Speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
