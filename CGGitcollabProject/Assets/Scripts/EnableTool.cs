using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTool : MonoBehaviour
{
    public GameObject tool;
    public void OnTriggerEnter(Collider other)
    {
        tool.SetActive(true);
    }
}
