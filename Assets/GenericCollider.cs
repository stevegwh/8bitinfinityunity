using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class GenericCollider : MonoBehaviour
{

    public UnityEvent onCollision;
    public List<Collider2D> validCollisions;
    private GameObject broadcastMessageTarget;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (validCollisions.Contains(col))
        {
            onCollision.Invoke();
        }
    }

    public void SetBroadCastMessageTarget(string targetName)
    {
        broadcastMessageTarget = GameObject.Find(targetName);
    }

    public void BroadcastToTarget(string methodName)
    {
        if (!broadcastMessageTarget)
        {
            Debug.Log("Warning, no broadcast message target has been found. Aborting...");
            return;
        }
        broadcastMessageTarget.BroadcastMessage(methodName);
    }
    
}
