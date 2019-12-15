using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] public int score = 0;

    [SerializeField] Text livesText;
    [SerializeField] Text scoreText;
    [SerializeField] Text persenText;
    private void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = playerLives.ToString();
        scoreText.text = score.ToString();
        persenText.text = "0%";
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        if (score%10 == 0) {
            playerLives += 1;
            livesText.text = playerLives.ToString();
        }
        scoreText.text = score.ToString();
    }

    public void AddToPersen(float stunRate)
    {
        if (stunRate == 2f)
            persenText.text = "25%";
        else if (stunRate == 3f)
            persenText.text = "50%";
        else if (stunRate == 4f)
            persenText.text = "75%";
        else if (stunRate == 5f)
            persenText.text = "100%";
    }
    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession(3);
        }
    }
   
    public void ResetGameSession(int i)
    {
        SceneManager.LoadScene(i);
        Destroy(gameObject);
    }
    private void TakeLife()
    {
        playerLives--;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        livesText.text = playerLives.ToString();
        persenText.text = "0%";
    }
}
