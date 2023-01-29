using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    // Start is called before the first frame updat
    [SerializeField] GameObject Bullet, shootpoint;
    
    public void Shoot()
    {
        Instantiate(Bullet, shootpoint.transform.position, Quaternion.identity);
    }
}
