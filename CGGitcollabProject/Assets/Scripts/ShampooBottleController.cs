using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShampooBottleController : MonoBehaviour
{
    public GameObject shampooParticles;

    public void OnTriggerEnter(Collider other)
    {
        shampooParticles.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        shampooParticles.SetActive(false);
    }
}
