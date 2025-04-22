using UnityEngine;
using TMPro;
using System; // Only if using TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText; // Use Text for normal UI.Text

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddPoint()
    {
        score++;
        UpdateScoreUI();
        Debug.Log("Score: " + score);
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
