using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDrumstickController : MonoBehaviour
{
    public GameObject snareLeft;

    public void OnTriggerEnter(Collider other)
    {
        snareLeft.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        snareLeft.SetActive(false);
    }
}
