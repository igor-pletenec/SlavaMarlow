using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPointer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isDown { get; private set; } // Проверка, нажата ли кнопка для управления

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }
}
