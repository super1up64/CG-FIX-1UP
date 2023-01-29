using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixTriggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.queriesHitTriggers = false;
    }
}
