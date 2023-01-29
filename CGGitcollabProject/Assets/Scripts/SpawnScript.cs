using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objToSpawn;
    public void SpawnObject()
    {
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
    }
}
