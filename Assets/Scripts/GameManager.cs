using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private float health;
    private float score;
    [SerializeField] private TextMeshProUGUI pointsText, livesText;
    [SerializeField] private SpawnManager spawnManager;
    [SerializeField] private GameObject gameOverPanel;


    void Start()
    {
        health = 3;
        score = 0;
        livesText.text = $"Lives: {health}";
        pointsText.text = $"Score: {score}";
    }
    private void OnEnable()
    {
        spawnManager.onFruitDestroyed += OnHit;
        spawnManager.onCaughtFruit += OnCatch;
    }

    private void OnDisable()
    {
        spawnManager.onFruitDestroyed -= OnHit;
    }
    void OnHit(float d)
    {
        health -= d;
        livesText.text = $"Lives: {health}";
        if (health <= 0)
        {
            livesText.text = $"Lives: 0";
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    
    void OnCatch(float points)
    {
        score += points;
        pointsText.text = $"Score: {score}";
    }        


}
