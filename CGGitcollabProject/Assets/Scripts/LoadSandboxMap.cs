using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class LoadSandboxMap : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Sandbox");
       
    }
}
