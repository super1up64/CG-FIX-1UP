using UnityEngine.Networking;
using UnityEngine;
using TMPro;
using System.Collections;
public class MOTDboard : MonoBehaviour
{
    string textURL = "https://pastebin.com/raw/729A9Lrf";
    public TMP_Text MOTD;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetText(textURL));
    }
    public IEnumerator GetText(string tURL)
    {
        UnityWebRequest www = UnityWebRequest.Get(tURL);
        yield return www.SendWebRequest();
        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log(www.error);
            MOTD.text = www.error;
        }
        else
        {
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
            string pathTxt = www.downloadHandler.text;
            //Debug.Log(pathTxt);
            MOTD.text = pathTxt;
        }
    }
}