using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int targetScore = 6;

    public TextMeshProUGUI scoreText;
    public GameObject winText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        score += amount;

        UpdateScoreUI();

        if (score >= targetScore)
        {
            WinGame();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void WinGame()
    {
        winText.SetActive(true);

        Time.timeScale = 0;
    }
}