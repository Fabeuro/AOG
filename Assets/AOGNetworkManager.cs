using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEditor.Search;

public class AOGNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("Server Started!");
    }

    public override void OnStopServer()
    {
        Debug.Log("Server Stopped!");
    }

    public override void OnClientConnect()
    {
        Debug.Log("Connected To Server!");
    }

    public override void OnClientDisconnect()
    {
        Debug.Log("Disconnected From Server!");
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        GameManager.instance.AddPlayerName();
    }
}

