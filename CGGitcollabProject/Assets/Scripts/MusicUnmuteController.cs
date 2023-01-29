using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicUnmuteController : MonoBehaviour
{
    public AudioSource music;

    public void OnTriggerEnter(Collider other)
    {
        music.Play();
    }


}
