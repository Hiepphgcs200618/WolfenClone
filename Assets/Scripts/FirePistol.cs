using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject gun;
    public GameObject nuzzleFlash;
    public AudioSource gunFire;
    public bool isFiring;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!isFiring)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {
        isFiring = true;
        gun.GetComponent<Animator>().Play("FirePistol");
        nuzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        nuzzleFlash.SetActive(false);
        gun.GetComponent<Animator>().Play("Idle");
        yield return new WaitForSeconds(0.25f);
        isFiring = false;
    }
}
