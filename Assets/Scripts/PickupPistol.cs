using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPistol : MonoBehaviour
{
    public static bool isAvailable = false;
    public GameObject pistol;
    public GameObject pistol_Pickup;
    public AudioSource gun_Pickup_Sound;
    void OnTriggerEnter(Collider other)
    {
        pistol.SetActive(true);
        pistol_Pickup.SetActive(false);
        gun_Pickup_Sound.Play();
        isAvailable = true;
    }
}
