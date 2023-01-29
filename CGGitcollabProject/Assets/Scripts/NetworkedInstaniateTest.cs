using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkedInstaniateTest : MonoBehaviour
{
    public GameObject obj;

    public void OnTriggerEnter(Collider other)
    {
        PhotonNetwork.Instantiate(obj.ToString(), transform.position, Quaternion.identity);
    }
}
