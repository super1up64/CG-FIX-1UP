using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagScript : MonoBehaviour
{
    public GameObject Empty;
    public GameObject Particle;
    public GameObject TaggedPlayer;
    public GameObject UnTaggedPlayer;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tagger"))
        Empty.SetActive(false);
        TaggedPlayer.SetActive(true);
        Particle.SetActive(true);
        UnTaggedPlayer.SetActive(false);
    }
}
