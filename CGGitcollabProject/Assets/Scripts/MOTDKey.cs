using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOTDKey : MonoBehaviour
{

    public GameObject motd;
    public GameObject disableGameObj;
    

    public void OnTriggerEnter()
    {
        motd.SetActive(true);
        disableGameObj.SetActive(false);
    }
}
