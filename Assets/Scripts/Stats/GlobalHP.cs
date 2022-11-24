using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHP : MonoBehaviour
{
    public GameObject displayHP;
    public static int valueHP;
    public int internalHP;
    void Start()
    {
        valueHP = 100;
    }
    void Update()
    {
        internalHP = valueHP;
        displayHP.GetComponent<Text>().text = "" + valueHP +"%"; 
    }
}
