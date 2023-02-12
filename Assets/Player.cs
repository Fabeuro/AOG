using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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


public class Player : MonoBehaviour
{
    public Card textCard, textCard2, imageCard, imageCard2, WildCard;
    public List<Card> promptCards = new List<Card>();
    public Card selectedCard;
    public GameObject CardPrefab;
}
