using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class RoomController : MonoBehaviourPunCallbacks
{
    [SerializeField] private byte maxPlayers = 2;
    [SerializeField] private string roomName = "MyRoom";

    private void Start()
    {
        ConnectToPhoton();
    }
    void ConnectToPhoton()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Master Server");
        Join1vs1Room();
    }

    public void Join1vs1Room()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public void Join2vs2Room()
    {
        RoomOptions roomOptions = new RoomOptions { MaxPlayers = maxPlayers };
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room: " + PhotonNetwork.CurrentRoom.Name);

        if (PhotonNetwork.CurrentRoom.PlayerCount == maxPlayers)
        {
            StartGame();
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("No available rooms, creating a new 1vs1 room...");
        Create1vs1Room();
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.LogWarningFormat("Failed to join room: {0}, Error: {1}", roomName, message);
    }

    private void Create1vs1Room()
    {
        RoomOptions roomOptions = new RoomOptions { MaxPlayers = 2 };
        PhotonNetwork.CreateRoom(null, roomOptions, TypedLobby.Default);
    }

    private void StartGame()
    {
      
        PhotonNetwork.LoadLevel("Lobby");
    }
}