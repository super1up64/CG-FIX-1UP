using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VersionText : MonoBehaviour
{

    public TMP_Text versionText;
    // Start is called before the first frame update
    void Start()
    {
        versionText.text = "v" + Application.version.ToString();
    }

    
}
