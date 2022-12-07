using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GlobalSceneIndex.currentIndex += 1;
        SceneManager.LoadScene(2);
    }
}
