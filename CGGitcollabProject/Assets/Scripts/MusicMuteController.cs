using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicMuteController : MonoBehaviour
{

    public AudioSource music;

    public void OnTriggerEnter(Collider other)
    {
        music.Pause();
    }

    
}
