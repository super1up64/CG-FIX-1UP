using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{

    public AudioSource music;

    public void OnTriggerEnter(Collider other)
    {
        music.Play();
    }

    public void OnTriggerExit(Collider other)
    {
        music.Stop();
    }
}
