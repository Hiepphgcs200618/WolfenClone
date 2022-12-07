using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public AudioSource fireSound;
    public AudioSource ouchSound;
    public bool isFiring = false;
    public float fireRate = 1f;
    public GameObject hurtScreen;
    public int bulletDamage = 5;
    void Update()
    {
        hitTag = LookAtTag.hitTag;

        if  (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if  (hitTag != "Player")
        {
            theSoldier.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
        
        IEnumerator EnemyFire()
        {
            isFiring = true;
            theSoldier.GetComponent<Animator>().Play("Shoot", -1 ,0);
            theSoldier.GetComponent<Animator>().Play("Shoot");
            fireSound.Play();
            lookingAtPlayer = true;
            yield return new WaitForSeconds(0.15f);
            ouchSound.Play();
            hurtScreen.SetActive(true);
            yield return new WaitForSeconds(0.05f);
            hurtScreen.SetActive(false);
            GlobalHP.valueHP -= bulletDamage;
            yield return new WaitForSeconds(fireRate-0.2f);
            isFiring = false;
        }
    }
}
