using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRedirect : MonoBehaviour
{
    public GameObject wasted;
    public GameObject buttonRestart;
    public GameObject buttonQuit;
    void Start()
    {
        StartCoroutine(Redirect());
    }

    IEnumerator Redirect()
    {
        wasted.SetActive(true);
        yield return new WaitForSeconds(1);
        buttonRestart.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        buttonQuit.SetActive(true);
    }

    //SceneManager.LoadScene(GlobalSceneIndex.currentIndex);
}
