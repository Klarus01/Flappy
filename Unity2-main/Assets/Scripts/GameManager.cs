using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public int points = 0;
    public int highscore = 0;

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        highscore = PlayerPrefs.GetInt("Highscore");
        if (points > highscore)
        {
            highscore = points;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
        highscoreText.SetText(highscore.ToString());
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.SetText(points.ToString());
    }
}
