using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAmmo : MonoBehaviour
{

    public GameObject ammo_Pickup;
    public AudioSource ammo_Pickup_Sound;
    void OnTriggerEnter(Collider other)
    {
        ammo_Pickup.SetActive(false);
        ammo_Pickup_Sound.Play();
        GlobalAmmo.stock_Ammo[0] += 20;
        GlobalAmmo.stock_Ammo[1] += 40;
        GlobalAmmo.stock_Ammo[2] += 10;
    }
}
