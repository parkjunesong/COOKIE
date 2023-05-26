using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] Obstacles = new GameObject[5];
    public GameObject[] Items = new GameObject[5];
    public float SpawnCycle;

    void Start()
    {
        SpawnCycle = 3.5f;
        StartCoroutine("MapMaker");
        
    }

    IEnumerator MapMaker()
    {
        yield return new WaitForSeconds(SpawnCycle); // 3.5f 이하로는 장애물 겹침.

        int ran = Random.Range(0, 3) + 1;

        if (ran == 1)
        {
            Spawn_Obstacle(0, 0);
            Spawn_Obstacle(1, 1);
            Spawn_Obstacle(2, 0);
        }    
        else if(ran == 2)
        {
            Spawn_Obstacle(0, 1);
            Spawn_Obstacle(1, 1);
            Spawn_Obstacle(2, 1);
        }
        else if (ran == 3)
        {
            Spawn_Obstacle(0, 1);
            Spawn_Obstacle(1, 0);
            Spawn_Obstacle(2, 1);
        }

        StartCoroutine("MapMaker");
    }

    void Spawn_Obstacle(int pos, int type)
    {
        Instantiate(Obstacles[type], new Vector3(10 + pos * 8, Obstacles[type].transform.position.y, 0), Quaternion.identity);
    }
}
