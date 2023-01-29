using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableParticleController : MonoBehaviour
{

    public GameObject particles;
    public AudioSource cosmeticSfx;


    public void OnTriggerEnter(Collider other)
    {
        particles.SetActive(true);
        cosmeticSfx.Play();
    }

    public void OnTriggerExit(Collider other)
    {
        particles.SetActive(false);
    }
}
