using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        DebugManager.Instance.DebugLog("debug log pressed", gameObject.tag);
    }

    [ContextMenu("Debug Error")]
    private void DebugLogError()
    {
        //DebugManager.Instance.DebugLogError();
    }

    [ContextMenu("Debug Warning")]
    private void DebugLogWarning()
    {
        DebugManager.Instance.DebugLogWarning("debug log warning pressed", gameObject.tag);
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
