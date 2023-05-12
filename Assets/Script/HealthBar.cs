using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public float maxHealth = 100f;
    public GameObject gameOverPanel;

    private float currentHealth;

    void Awake()
    {
        slider = GetComponent<Slider>(); // slider 변수 초기화
    }

    void Start()
    {
        currentHealth = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        // 일정한 속도로 체력 감소
        currentHealth -= Time.deltaTime * 1.5f;
        slider.value = currentHealth;

        // 체력이 0이 되면 게임 오버 처리
        if (currentHealth <= 0f)
        {
            Time.timeScale = 0f; // 게임 일시정지
            gameOverPanel.SetActive(true); // 게임 오버 창 띄우기
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        // 충돌한 오브젝트가 "Obstacle" 태그를 가진 경우에만 체력 감소
        if (collision.CompareTag("Obstacle"))
        {
            currentHealth -= 20f;
            slider.value = currentHealth;
        }
    }
}
