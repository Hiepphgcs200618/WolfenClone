using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour
{
    public GameObject fadeOut;

    void Update()
    {
        if (GlobalHP.valueHP == 0)
        {
            StartCoroutine(GameOver());
        }
    }

     IEnumerator GameOver()
     {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);
     }
}
