using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTool : MonoBehaviour
{
    public GameObject tool;
    public void OnTriggerEnter(Collider other)
    {
        tool.SetActive(false);
    }
}
