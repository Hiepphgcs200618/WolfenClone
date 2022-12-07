using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    void OnTriggerEnter(Collider other)
    {
            StartCoroutine(OpenDoor());
    }
    IEnumerator OpenDoor()
    {
        door.GetComponent<Animator>().Play("Open");
        yield return new WaitForSeconds(3);
        door.GetComponent<Animator>().Play("Close");
    }
}
