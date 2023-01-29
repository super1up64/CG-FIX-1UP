using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGun : MonoBehaviour
{

    public GameObject objToSpawn;
    public float speed = 100f;
    

    public void OnTriggerEnter(Collider other)
    {
        GameObject instBullet = Instantiate(objToSpawn, transform.position, Quaternion.identity) as GameObject;
        Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
        instBulletRigidbody.AddForce(transform.forward * speed);
    }
}