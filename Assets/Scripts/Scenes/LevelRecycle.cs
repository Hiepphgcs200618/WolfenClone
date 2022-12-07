using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRecycle : MonoBehaviour
{
    void Start()
    {
        if (GlobalSceneIndex.currentIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(GlobalSceneIndex.currentIndex);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
