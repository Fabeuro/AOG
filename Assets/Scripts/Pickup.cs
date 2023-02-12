using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(eventData.position);
    }
}
