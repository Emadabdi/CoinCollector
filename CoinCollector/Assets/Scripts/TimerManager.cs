using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TextMeshProUGUI timerText;
    public GameObject gameOverText;

    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded)
            return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeRemaining);
        }
        else
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameEnded = true;

        timerText.text = "Time: 0";

        gameOverText.SetActive(true);

        Time.timeScale = 0;
    }
}