using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupShotgun : MonoBehaviour
{
    public static bool isAvailable = true;
    public GameObject Shotgun;
    public GameObject Shotgun_Pickup;
    public AudioSource gun_Pickup_Sound;
    void OnTriggerEnter(Collider other)
    {
        Shotgun.SetActive(true);
        Shotgun_Pickup.SetActive(false);
        gun_Pickup_Sound.Play();
        isAvailable = true;
    }
}
