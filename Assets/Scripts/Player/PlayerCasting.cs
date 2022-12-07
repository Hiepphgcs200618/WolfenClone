using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distantFromTarget;
    public float toTarget;
    public static RaycastHit hit;
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit))
        {
            toTarget = hit.distance;
            distantFromTarget = toTarget;
        }
    }
}
