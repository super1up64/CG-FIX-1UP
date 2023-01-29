using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.VR;
using Photon.Pun;
using TMPro;

public class ExecuteButtonRoom : MonoBehaviour
{
    public RoomScript roomScript;
    public string HandTag;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == HandTag)
        {
            PhotonNetwork.Disconnect();
            PhotonVRManager.JoinPrivateRoom(roomScript.RoomVar, 10);
        }
    }
}
