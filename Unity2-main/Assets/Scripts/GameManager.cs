using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public ScoreManager sm;
    public int points = 0;
    public int highscore = 0;

    public void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {
        sm.loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        sm = FindObjectOfType<ScoreManager>();
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        if (points > highscore)
        {
            highscore = points;
            sm.highscoreText.SetText(highscore.ToString());
        }
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        sm.scoreText.SetText(points.ToString());
    }
}
