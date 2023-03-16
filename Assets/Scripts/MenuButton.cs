using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class MenuButton : MonoBehaviour
{
    public UnityEvent onClick;

    private void OnMouseDown()
    {
        onClick.Invoke();
    }
}
