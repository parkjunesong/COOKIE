using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefab = new GameObject[5]; //장애물 오브젝트의 프리팹을 가리키는 변수
    public float spawnInterval = 2f; //장애물 스폰 주기를 결정하는 변수
    //장애물 위치 제한하는 변수

    void Start()
    {
      StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
      //1.0f 매개변수로 입력한 숫자에 해당하는 초만큼 기다렸다가 실행
      //unity상에서의 시간을 기준으로 체크
      int i = UnityEngine.Random.Range(0,3);
      yield return new WaitForSeconds(spawnInterval);
      SpawnObstacle(i);
      StartCoroutine(SpawnObstacles());
    }

    void SpawnObstacle(int i)
    {
      float x = 10;
      float y = obstaclePrefab[i].transform.position.y;
      Vector3 spawnPosition = new Vector3(x, y, 0f);
      Instantiate(obstaclePrefab[i], spawnPosition, Quaternion.identity);
    }

}
/*update문을 사용하면 원하든 원하지 않든 update문이 매 프레임마다 반복적으로 진행
코루틴을 사용한다면 자신이 필요한 순간에만 반복하고 필요하지 않을때는 사용하지 않는다
자원관리 효과적

코루틴은 IEnumerator라는 반환형으로 시작해야한다.
yield return이 반드시 함수 내부에 존재해야한다.
*/
