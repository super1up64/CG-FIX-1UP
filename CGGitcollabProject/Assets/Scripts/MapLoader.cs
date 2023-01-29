using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public GameObject mapEnable;
    public GameObject mapDisable;

    public void OnTriggerEnter()
    {
        mapEnable.SetActive(true);
        mapDisable.SetActive(false);
    }
}
