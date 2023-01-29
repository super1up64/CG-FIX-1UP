using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{

    public Animator myDoor = null;

    public bool openTrigger = false;
    

    public string doorOpen;
    public string doorClose;


    public void OnTriggerEnter(Collider other)
    {
        myDoor.Play(doorOpen, 0, 0.0f);


    }

    public void OnTriggerExit(Collider other)
    {
        myDoor.Play(doorClose, 0, 0.0f);
    }

}
