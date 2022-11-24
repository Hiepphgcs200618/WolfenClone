using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject gun;
    public GameObject nuzzleFlash;
    public AudioSource gunFire;
    public AudioSource emptyFire;
    public AudioSource reloadSound;
    public GameObject reloadNotify;
    public int maxAmmo, currentAmmo;
    public float fireTimer,reloadTimer;
    public bool isFiring;
    void Update()
    {
        currentAmmo = GlobalAmmo.loaded_Ammo[WeaponHolder.currentGun];
        if (currentAmmo < maxAmmo/4 && GlobalAmmo.stock_Ammo[WeaponHolder.currentGun] > 0)
        {
            reloadNotify.SetActive(true);
        } else{
            reloadNotify.SetActive(false);
        }

        if (Input.GetButton("Fire1"))
        {
            if (currentAmmo <= 0)
            {
                emptyFire.Play();
            } else
            if (!isFiring)
            {
                StartCoroutine(GunFire());
            }
        }
        if (Input.GetButtonDown("Reload") && currentAmmo < maxAmmo)
        {
            StartCoroutine(Reload());
        }
    }
    IEnumerator Reload()
    {
        gun.GetComponent<Animator>().Play("Reload");
        reloadSound.Play();
        isFiring = true;
        yield return new WaitForSeconds(reloadTimer);
        if (GlobalAmmo.stock_Ammo[WeaponHolder.currentGun] < maxAmmo)
        {
            GlobalAmmo.loaded_Ammo[WeaponHolder.currentGun] += GlobalAmmo.stock_Ammo[WeaponHolder.currentGun];
            GlobalAmmo.stock_Ammo[WeaponHolder.currentGun] = 0;
        } else{
            GlobalAmmo.stock_Ammo[WeaponHolder.currentGun] -= maxAmmo - GlobalAmmo.loaded_Ammo[WeaponHolder.currentGun];
            GlobalAmmo.loaded_Ammo[WeaponHolder.currentGun] = maxAmmo;
        }
        isFiring = false;
        reloadSound.Stop();
        gun.GetComponent<Animator>().Play("Idle");
    }
    IEnumerator GunFire()
    {
        isFiring = true;
        gun.GetComponent<Animator>().Play("Fire");
        nuzzleFlash.SetActive(true);
        gunFire.Play();
        GlobalAmmo.loaded_Ammo[WeaponHolder.currentGun] -=1;
        yield return new WaitForSeconds(0.05f);
        nuzzleFlash.SetActive(false);
        //yield return new WaitForSeconds(0.05f);
        gun.GetComponent<Animator>().Play("Idle");
        yield return new WaitForSeconds(fireTimer);
        isFiring = false;
    }
}
