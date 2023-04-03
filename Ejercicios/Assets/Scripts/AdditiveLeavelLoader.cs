using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveLeavelLoader : MonoBehaviour
{
    [SerializeField] private int levelBuildIndex = 1;

    [ContextMenu("Load Level")]
    public void LoadLevelBased(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex, LoadSceneMode.Additive);
    }

    [ContextMenu("Load Level")]
    public void LoadLevelBasedOnIndex()
    {
        SceneManager.LoadScene(levelBuildIndex, LoadSceneMode.Additive);
    }

    [ContextMenu("Load Level 1", true)]
    private bool ValidateLoadLevel()
    {
        return Application.isPlaying;
    }

    [ContextMenu("Unload Level")]
    private void UnloadLevel()
    {
        SceneManager.UnloadSceneAsync(levelBuildIndex);
    }
}
