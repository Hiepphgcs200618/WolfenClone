using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadein : MonoBehaviour
{
    public GameObject blackscreen;
    void Start()
    {
        StartCoroutine(FadeScreenIn());
    }
    IEnumerator FadeScreenIn()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(false);
    }
}
