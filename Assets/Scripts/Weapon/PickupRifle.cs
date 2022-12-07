using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRifle : MonoBehaviour
{
    public static bool isAvailable = false;
    public GameObject Rifle;
    public GameObject Rifle_Pickup;
    public AudioSource gun_Pickup_Sound;
    void OnTriggerEnter(Collider other)
    {
        //Rifle.SetActive(true);
        Rifle_Pickup.SetActive(false);
        gun_Pickup_Sound.Play();
        isAvailable = true;
    }
}
