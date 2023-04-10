using TMPro;
using UnityEngine;


public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMP_Text scoreText;

    private void OnEnable()
    {
        player.OnUpdateScore += HandleUpdateScore;
    }

    private void OnDisable()
    {
        player.OnUpdateScore -= HandleUpdateScore;
    }

    private void HandleUpdateScore(int newScore)
    {
        scoreText.text = $"Score: {newScore}";
    }
}
