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
        slider = GetComponent<Slider>(); // slider ���� �ʱ�ȭ
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
        // ������ �ӵ��� ü�� ����
        currentHealth -= Time.deltaTime * 1.5f;
        slider.value = currentHealth;

        // ü���� 0�� �Ǹ� ���� ���� ó��
        if (currentHealth <= 0f)
        {
            Time.timeScale = 0f; // ���� �Ͻ�����
            gameOverPanel.SetActive(true); // ���� ���� â ����
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        // �浹�� ������Ʈ�� "Obstacle" �±׸� ���� ��쿡�� ü�� ����
        if (collision.CompareTag("Obstacle"))
        {
            currentHealth -= 20f;
            slider.value = currentHealth;
        }
    }
}
