using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    private bool startFollowMouse;

    private void OnMouseDown()
    {
        Debug.Log("Clicked!");
        startFollowMouse = true;
        Cursor.visible = false;
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (!startFollowMouse) return;
        //Vector3 mousePosition = mousePositionReference.action.ReadValue<Vector2>();
        transform.position = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
}
