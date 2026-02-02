using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private float health;
    private float score;
    [SerializeField] private SpawnManager spawnManager;

    void Start()
    {
        health = 3;
        Debug.Log("Health: " + health);

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
        Debug.Log("Health: " + health);
        if (health <= 0)
        {
            Debug.Log("Health: " + health);
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0f;
    }
    
    void OnCatch(float points)
    {
        score += points;
        Debug.Log("Score: " +  score);
    }        
}
