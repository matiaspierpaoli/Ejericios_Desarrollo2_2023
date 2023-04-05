using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //[SerializeField] private int levelBuildIndex;

    [ContextMenu("Load Scene")]
    public void LoadLevel(int levelBuildIndex)
    {
        SceneManager.LoadScene(levelBuildIndex);
    }

    //[ContextMenu("Load Main Menu")]
    //public void LoadMainMenu()
    //{
    //    SceneManager.LoadScene(0);
    //}

    //[ContextMenu("Load Credits")]
    //public void LoadCredits()
    //{
    //    SceneManager.LoadScene(2);
    //}

    //[ContextMenu("Load Level 1", true)]
    //public bool ValidateLoadLevel1()
    //{
    //    return Application.isPlaying;
    //}
}
