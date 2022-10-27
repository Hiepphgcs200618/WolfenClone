using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAmmo : MonoBehaviour
{
    public GameObject ammo;
    public GameObject pistol_Pickup;
    public AudioSource ammo_Pickup_Sound;
    void OnTriggerEnter(Collider other)
    {
        ammo.SetActive(false);
    }
}
