using Mirror;
using UnityEngine;

public class GameManager : NetworkBehaviour
{
    public static GameManager instance;

    public GameObject NameListPrefab;
    public Transform NameListParent;

    private void Awake()
    {
        instance = this;
    }

    public void AddPlayerName()
    {
        GameObject g = Instantiate(NameListPrefab, NameListParent.transform);
        g.GetComponent<TMPro.TMP_Text>().text = "Player " + Random.Range(0, 100).ToString();
    }
}