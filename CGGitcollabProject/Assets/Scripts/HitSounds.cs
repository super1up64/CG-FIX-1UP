using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSounds : MonoBehaviour
{
    public AudioSource leftHitSound;
    public AudioSource rightHitSound;


    private void Start()
    {
        Physics.queriesHitTriggers = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LeftHand Controller")
        {
            leftHitSound.Play();

        }
        if (other.gameObject.name == "RightHand Controller")
        {
            rightHitSound.Play();
        }
    }


}
