using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorDebug : MonoBehaviour
{
    
    public void OnTriggerEnter()
    {
        Application.Quit();
    }
}
