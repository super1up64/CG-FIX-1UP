 
using UnityEngine;
using System.Collections;
 
public class LookAtCameraYRotationOnly : MonoBehaviour
{
    public GameObject cameraToLookAt;
 
    void Update()
    {
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(cameraToLookAt.transform.position - v);
    }
}
 