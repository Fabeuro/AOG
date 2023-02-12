using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Mirror;
using System;

public enum CardType
{
    Text,
    Image,
    Wild
}

[SerializeField]
public class Card
{
    public CardType type;
    public string text;
    public Sprite image;
}


public class CardObject : NetworkBehaviour
{
    public Card thisCard;

    private void Start()
    {
        SelectServerCard();
    }

    [ClientRpc] //sends only to server
    public void SelectServerCard()
    {
        Debug.Log("EHL");
    }

}