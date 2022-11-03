using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distantFromTarget;
    public float toTarget;
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out Hit))
        {
            toTarget = Hit.distance;
            distantFromTarget = toTarget;
        }
    }
}
