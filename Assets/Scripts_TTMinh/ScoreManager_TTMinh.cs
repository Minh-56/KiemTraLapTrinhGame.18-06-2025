using UnityEngine;
using TMPro;

public class ScoreManager_TTMinh : MonoBehaviour
{
    public static ScoreManager_TTMinh instance;
    public TMP_Text scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore_TTMinh(int amount)
    {
        score += amount;
        scoreText.text = "Điểm: " + score;
    }

    public void ResetScore()
    { 
        score = 0; 
    }
}
