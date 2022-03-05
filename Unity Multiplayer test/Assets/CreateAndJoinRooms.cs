using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("GameRoom");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("GameRoom");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
