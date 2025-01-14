using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkPlayer : NetworkBehaviour
{


    public PlayerController playerController

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        playerController.enabled = !IsOwner;
    }
}