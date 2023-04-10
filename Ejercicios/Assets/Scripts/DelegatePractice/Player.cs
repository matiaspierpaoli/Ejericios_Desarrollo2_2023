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
        // DebugManager.Instance.DebugDrawLine();
    }

    [ContextMenu("Debug DrawRay")]
    private void DebugDrawRay()
    {
        //DebugManager.Instance.DebugDrawRay();
    }
}
