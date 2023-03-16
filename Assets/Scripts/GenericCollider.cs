using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class GenericCollider : MonoBehaviour
{

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public List<Collider2D> validCollisions;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (validCollisions.Contains(col))
        {
            onTriggerEnter.Invoke();
        }
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        if (validCollisions.Contains(col))
        {
            onTriggerExit.Invoke();
        }
    }

}
