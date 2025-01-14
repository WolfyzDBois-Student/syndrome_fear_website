using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient():
    }

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost():
    }
}