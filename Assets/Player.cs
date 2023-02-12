using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

public class Player : NetworkBehaviour
{
    [SyncVar(hook = nameof(onReady))] public bool ready;

    private void onReady(bool old, bool updated)
    {
        if (updated == true) GameManager.instance.AddPlayerName();
    }

    private void Start()
    {
        CommandSetReady();
    }

    [Command]
    public void CommandSetReady()
    {
        ready = true;
    }
}
