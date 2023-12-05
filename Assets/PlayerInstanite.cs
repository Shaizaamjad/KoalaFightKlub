using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstanite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
        Debug.Log("Player instantiated");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
