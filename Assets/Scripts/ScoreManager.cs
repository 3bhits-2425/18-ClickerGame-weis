using UnityEngine;
using TMPro; // Wichtig!

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score = 0;
    public TMP_Text scoreText;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddPoints(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
