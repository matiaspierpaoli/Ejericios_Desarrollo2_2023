using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int levelBuildIndex = 1;

    [ContextMenu("Load Level 1")]
    private void LoadLevel1()
    {
        SceneManager.LoadScene(levelBuildIndex);
    }

    [ContextMenu("Load Level 1", true)]
    private bool ValidateLoadLevel1()
    {
        return Application.isPlaying;
    }
}
