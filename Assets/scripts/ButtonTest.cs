using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTest : MonoBehaviour, IPointerDownHandler
{
    public car player;

    public void OnPointerDown(PointerEventData eventData)
    {
        player.MoveForward();
    }
}