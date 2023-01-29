using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.VR;

public class LoadNormalMap : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.LoadLevel("Game");
        
       
    }
}
