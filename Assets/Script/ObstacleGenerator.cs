using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefab = new GameObject[5]; //장애물 오브젝트의 프리팹을 가리키는 변수
    public GameObject[] itemPrefab = new GameObject[5];
    public GameObject[] scaffoldingPrefab = new GameObject[5];
    public float spawnInterval = 3.5f; //장애물 스폰 주기를 결정하는 변수

    void Start()
    {
      StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
      yield return new WaitForSeconds(spawnInterval);

        int ran = Random.Range(0, 5) + 1; // 1~10      

        if (ran == 1) //2단 점프 연속
        {
            Spawn_Obstacle(1, 1);
            Spawn_Obstacle(1, 2);
            Spawn_Obstacle(1, 3);
            Spawn_Obstacle(1, 4);
            Spawn_Obstacle(1, 5);

            Spawn_Scaffolding(1, new Vector2(3, 0));


        }
        else if (ran == 2)  //1단 점프 연속
        {
            Spawn_Obstacle(0, 1);
            Spawn_ObsWithScaff(0, 2);
            Spawn_Obstacle(0, 3);
        }
        else if (ran == 3)  //1단 + 2단 점프
        {
            Spawn_ObsWithScaff(0, 1);
            Spawn_ObsWithScaff(1, 6);
        }
        else if (ran == 4)  //1단 + 1단 + 1단 + 1단
        {
            Spawn_Obstacle(0,1);
            Spawn_Obstacle(0,5);
            Spawn_Obstacle(0,9);
        }
        else if (ran == 5)  //1단 + 슬라이딩 + 2단
        {
          Spawn_Obstacle(0,1);
          Spawn_Obstacle(2,5);
          Spawn_Obstacle(1,9);
        }
        else if (ran == 6)
        {
          
        }
        else if (ran == 7)
        {
          
        }
        else if (ran == 8)
        {
          
        }
        else if (ran == 9)
        {
          
        }
        else if (ran == 10)
        {
          
        }
      StartCoroutine(SpawnObstacles());
    }

    void Spawn_ObsWithScaff(int type, int pos)
    {
        if (type == 0 || type == 1)
        {
            float y = 0;
            if (type == 0) y = -1.5f;
            else if (type == 1) y = 0f;

            Vector3 spawnPosition = new Vector3(pos + 10, obstaclePrefab[type].transform.position.y, 0f);

            Instantiate(obstaclePrefab[type], spawnPosition, Quaternion.identity);
            Instantiate(scaffoldingPrefab[0], new Vector3(pos + 10, y, 0f), Quaternion.identity);
        }
        else
            Debug.Log("이 타입의 장애물은 안됨.");
    }

    void Spawn_Obstacle(int type, int pos) 
    {
      float y = obstaclePrefab[type].transform.position.y;
      Vector3 spawnPosition = new Vector3(pos + 10, y, 0f);

      Instantiate(obstaclePrefab[type], spawnPosition, Quaternion.identity);
    }
    void Spawn_Scaffolding(int type, Vector2 pos)
    {
        Vector3 spawnPosition = new Vector3(pos.x + 10, pos.y, 0f);

        Instantiate(scaffoldingPrefab[type], spawnPosition, Quaternion.identity);
    }

}
