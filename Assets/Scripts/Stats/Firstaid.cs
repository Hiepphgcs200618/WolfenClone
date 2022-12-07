using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstaid : MonoBehaviour
{
    public AudioSource pickupSound;
    public GameObject healKit;
    void OnTriggerEnter(Collider other)
    {
        GlobalHP.valueHP += 50;
        if (GlobalHP.valueHP > 100)
        {
            GlobalHP.valueHP = 100;
        }
        pickupSound.Play();
        healKit.SetActive(false);
    }
}
