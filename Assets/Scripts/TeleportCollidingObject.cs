using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCollidingObject : MonoBehaviour
{
    [SerializeField] private Vector2 teleportPoint;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Enemy")) return;
        var newY = col.GetComponentInChildren<SpriteRenderer>().sprite.bounds.extents.y;
        if (teleportPoint.y < transform.position.y)
        {

            col.transform.position = new Vector3(teleportPoint.x, teleportPoint.y + newY, 0);
            
        }
        else
        {
            col.transform.position = new Vector3(teleportPoint.x, teleportPoint.y - newY, 0);
        }
        

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere((Vector3) teleportPoint, 0.2f);
    }
}
