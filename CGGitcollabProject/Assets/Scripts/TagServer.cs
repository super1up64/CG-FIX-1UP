using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;
public class TagServer : MonoBehaviour
{
    public string AppID;
    public string VoiceID;
    public GameObject PlayerPrefab;
    public GameObject TaggerPrefab;
    public GameObject PhotonSpawnerTag;
    public GameObject PhotonSpawnerNormal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandTag"))
        {
            PhotonVRManager.ChangeServers(AppID, VoiceID);
            PlayerPrefab.SetActive(true);
            TaggerPrefab.SetActive(true);
            PhotonSpawnerNormal.SetActive(false);
            PhotonSpawnerTag.SetActive(true);
        }
    }
}
