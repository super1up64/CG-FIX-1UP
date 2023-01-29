using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ConnectionChecker : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Application.internetReachability == NetworkReachability.NotReachable)
        {

            SceneManager.LoadScene("NoInternet");
            PhotonNetwork.Disconnect();
            
        }
        else
        {

            
        }
    }
}
