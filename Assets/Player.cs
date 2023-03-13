using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    private bool startFollowMouse;
    private readonly float speed = 2.5f;
    [SerializeField] private Vector2 hitbox = new (0.5f, 0.5f);

    private void OnMouseDown()
    {
        Debug.Log("Clicked!");
        startFollowMouse = true;
        GetComponent<BoxCollider2D>().size = hitbox;
        //  Cursor.visible = false;
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
        GameManager.Instance.RestartLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (!startFollowMouse) return;
        float step = speed * Time.deltaTime;
        var mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        var dist = Vector2.Distance(mousePos, transform.position);
        transform.position = Vector2.MoveTowards(transform.position, mousePos, 
            step * dist);

        
        //transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
}
