using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawn : MonoBehaviour
{

    public SpawnScript spawnScript;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        spawnScript.SpawnObject();
    }
}
