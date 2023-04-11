using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviourSingleton<DebugManager>
{
    [SerializeField] private string[] tags;
    [SerializeField] private bool log;
    [SerializeField] private bool logError;
    [SerializeField] private bool logWarning;
    [SerializeField] private bool drawLine;
    [SerializeField] private bool drawRay;

    public void Log(string message, GameObject gameObject)
    {
        if (log)
        for (int i = 0; i < tags.Length; i++)
        {
            if (tags[i] == gameObject.tag)
            {
                Debug.Log(message);
            }
        }        
    }

    public void LogError(string message, GameObject gameObject)
    {
        if (logError)
        {
            for (int i = 0; i < tags.Length; i++)
            {
                if (tags[i] == gameObject.tag)
                {
                    Debug.LogError(message);
                }
            }
        }          
    }

    public void LogWarning(string message, GameObject gameObject)
    {
        if (logWarning)
        {
            for (int i = 0; i < tags.Length; i++)
            {
                if (tags[i] == gameObject.tag)
                {
                    Debug.LogWarning(message);
                }
            }
        }
    }  

    public void DrawLine(Vector3 start, Vector3 end, Color color, float duration, GameObject gameObject)
    {
        if (drawLine)
        {
            for (int i = 0; i < tags.Length; i++)
            {
                if (tags[i] == gameObject.tag)
                {
                    Debug.DrawLine(start, end, color, duration);
                }
            }
        }     
    }

    public void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, GameObject gameObject)
    {
        if (drawRay)
        {
            for (int i = 0; i < tags.Length; i++)
            {
                if (tags[i] == gameObject.tag)
                {
                    Debug.DrawRay(start, dir, color, duration);
                }
            }
        }        
    }

}
