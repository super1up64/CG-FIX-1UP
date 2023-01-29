using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTool : MonoBehaviour
{
    
    public string deleteToolTag;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == deleteToolTag)
        {

            Destroy(gameObject);
        }
    }
}
