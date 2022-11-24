using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTag : MonoBehaviour
{
    public static string hitTag;
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out Hit))
        {
            hitTag = Hit.transform.tag;
        }
    }
}
