using Photon.Pun;
using TMPro;
public class RoomText : MonoBehaviourPunCallbacks
{
    public TMP_Text text;
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        text.text = "Connected to room " + PhotonNetwork.CurrentRoom.Name;
    }
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        text.text = "Not In Room";
    }
}