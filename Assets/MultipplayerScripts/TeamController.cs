using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class TeamController : MonoBehaviourPunCallbacks
{
    [SerializeField] private byte maxPlayers = 4;
    [SerializeField] private string roomName = "MyRoom";
    [SerializeField] private string nickName = "p1";

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.LocalPlayer.NickName = nickName;
        Hashtable customProperties = new Hashtable();
        customProperties.Add("Team", 0);
        PhotonNetwork.LocalPlayer.SetCustomProperties(customProperties);
        PhotonNetwork.JoinRandomRoom();

    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(roomName, new RoomOptions { MaxPlayers = maxPlayers });
    }

    public override void OnJoinedRoom()
    {
        int playerNumber = PhotonNetwork.LocalPlayer.ActorNumber;
        int teamNumber = playerNumber % 2;
        
        if (PhotonNetwork.LocalPlayer.CustomProperties.ContainsKey("Team"))
        {
            Hashtable customProperties = PhotonNetwork.LocalPlayer.CustomProperties;
            customProperties["Team"] = teamNumber; // Change the value to 1
            PhotonNetwork.LocalPlayer.SetCustomProperties(customProperties);
        }
        PhotonNetwork.LoadLevel(1);
    }
    
}