using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDrumstickController : MonoBehaviour
{
    public GameObject snareRight;

    public void OnTriggerEnter(Collider other)
    {
        snareRight.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        snareRight.SetActive(false);
    }
}
