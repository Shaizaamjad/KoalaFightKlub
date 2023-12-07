using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class RoomController : MonoBehaviourPunCallbacks
{
    [SerializeField] private byte maxPlayers = 2;
    [SerializeField] private string roomName = "MyRoom";

    public void ConnectToPhoton()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Master Server");
        PhotonNetwork.JoinOrCreateRoom(roomName, new RoomOptions { MaxPlayers = maxPlayers }, TypedLobby.Default);
        
    }
  
    public override void OnJoinedRoom()
    { 
            Debug.Log("Joined room: " + PhotonNetwork.CurrentRoom.Name);
            PhotonNetwork.LoadLevel(1);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.LogWarningFormat("Failed to join room: {0}, Error: {1}", roomName, message);
    }
}