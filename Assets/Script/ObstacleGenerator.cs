using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefab = new GameObject[5]; //장애물 오브젝트의 프리팹을 가리키는 변수
    public GameObject[] itemPrefab = new GameObject[5];
    public GameObject[] scaffoldingPrefab = new GameObject[5];
    public float spawnInterval = 2f; //장애물 스폰 주기를 결정하는 변수

    void Start()
    {
      StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
      yield return new WaitForSeconds(spawnInterval);

        int ran = Random.Range(0, 3) + 1; // 1~3       

        if (ran == 1)
        {
            Spawn_Obstacle(1, 1);
            Spawn_Obstacle(1, 2);
            Spawn_Obstacle(1, 3);
            Spawn_Obstacle(1, 4);
            Spawn_Obstacle(1, 5);

            Spawn_Scaffolding(1, new Vector2(3, 0));


        }
        else if (ran == 2)
        {
            Spawn_Obstacle(0, 1);
            Spawn_Obstacle(0, 2);
            Spawn_Obstacle(0, 3);

            Spawn_Scaffolding(0, new Vector2(2, -1.5f));
        }
        else if (ran == 3)
        {
            Spawn_Obstacle(0, 1);
            Spawn_Obstacle(1, 3);
            Spawn_Obstacle(2, 5);
        }

      StartCoroutine(SpawnObstacles());
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
