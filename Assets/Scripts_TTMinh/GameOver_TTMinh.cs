using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_TTMinh : MonoBehaviour
{
    public static GameOver_TTMinh Instance;
    public GameObject gameOverPanel;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void Gameover_TTMinh()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame_TTMinh()
    {
        ScoreManager_TTMinh.instance.ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame_TTMinh()
    {
        Application.Quit();
    }
}
