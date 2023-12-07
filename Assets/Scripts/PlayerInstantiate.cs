using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PlayerInstantiate : MonoBehaviourPunCallbacks
{
    [SerializeField] private Transform[] spawnPoints;
    public Material team1Material;
    public Material team2Material;

    private void Start()
    {
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        Vector3 spawnPosition = spawnPoints[randomSpawnIndex].position;

        GameObject currentPlayer = PhotonNetwork.Instantiate("Player", spawnPosition, Quaternion.identity);
        Material finalMaterial = team1Material;
        if (PhotonNetwork.LocalPlayer.CustomProperties.TryGetValue("Team", out object teamNumberObj))
        {
            int teamNumber = (int)teamNumberObj;
            if (teamNumber == 0)
            {
                Debug.Log("Player is in team 0");
                finalMaterial = team1Material;
            }
            else if (teamNumber == 1)
            {
                Debug.Log("Player is in team 1");
                finalMaterial = team2Material;
            }
            else
            {
                finalMaterial = null;
                Debug.Log("Invalid team number: " + teamNumber);
            }
        }
        else
        {
            Debug.Log("Player's team number is not set.");
        }
        currentPlayer.GetComponent<Renderer>().material = finalMaterial;

    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName);

        if (newPlayer.CustomProperties.ContainsKey("Team"))
        {
            Debug.Log("NewName");
        }
    }
}