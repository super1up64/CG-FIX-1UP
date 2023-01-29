using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpForceController : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 rbForceVector;

    public void OnTriggerEnter(Collider other)
    {
        rb.AddForce(rbForceVector, ForceMode.Impulse);
    }
}
