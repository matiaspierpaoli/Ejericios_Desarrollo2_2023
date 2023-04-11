using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private DebugManager debugManager;

    public delegate void ScoreEvent(int newScore);

    private int _score;
    public ScoreEvent OnUpdateScore;

    [ContextMenu("Test Update Score")]
    private void TestUpdateScore()
    {
        _score++;
        OnUpdateScore(_score);     
    }



    [ContextMenu("Debug Log")]
    private void DebugLog()
    {
        DebugManager.Instance.Log("calling log", gameObject);
    }

    [ContextMenu("Debug Error")]
    private void DebugLogError()
    {
        DebugManager.Instance.LogError("calling debug log error", gameObject);
    }

    [ContextMenu("Debug Warning")]
    private void DebugLogWarning()
    {
        DebugManager.Instance.LogWarning("calling debug log warning", gameObject);
    }

    [ContextMenu("Debug DrawLine")]
    private void DebugDrawLine()
    {
        Vector3 end = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), 0);
        Color color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        DebugManager.Instance.DrawLine(this.transform.position, this.transform.position + end, color, 2, gameObject);
    }

    [ContextMenu("Debug DrawRay")]
    private void DebugDrawRay()
    {
        Vector3 end = new Vector3(Random.Range(-50, 50), Random.Range(-50, 50), 0);
        Color color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        DebugManager.Instance.DrawRay(this.transform.position, this.transform.position + end, color, 2, gameObject);
    }
}
