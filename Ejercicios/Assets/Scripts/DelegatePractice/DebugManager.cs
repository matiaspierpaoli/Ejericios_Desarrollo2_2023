using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviourSingleton<DebugManager>
{
    // 
    // 
    // 

    public void DebugLog(string message, string tag)
    {
        Debug.Log(message);       
    }

    public void DebugLogError(string message, string tag)
    {
        Debug.LogError(message);
    }

    public void DebugLogWarning(string message, string tag)
    {
        Debug.LogWarning(message);
    }

    public void DebugDrawLine(Vector3 start, Vector3 end, Color color, string tag)
    {
        Debug.DrawLine(start, end, color);
    }

    public void DebugDrawRay(Vector3 start, Vector3 dir, Color color, string tag)
    {
        Debug.DrawRay(start, dir, color);
    }


}
