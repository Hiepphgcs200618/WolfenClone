using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyMesh;

    void DamageEnemy (int damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log("hit -" + damageAmount);
    }
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            StartCoroutine(Death());
        }
    }
    IEnumerator Death()
    {
        enemyDead = true;
        this.GetComponent<Animator>().Play("Death");
        this.GetComponent<EnemyAI>().enabled = false;
        yield return new WaitForSeconds(1);
        enemyMesh.SetActive(false);
    }
}
