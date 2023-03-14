using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationEnemy : PatrolEnemy
{
    [SerializeField] private Vector2 acceleration;
    [SerializeField] private Vector2 maxVelocity;
    void Start()
    {
        velocity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPatrol) return;
        velocity += acceleration;
        velocity = new Vector2(Mathf.Clamp(velocity.x, 0f, maxVelocity.x), 
            Mathf.Clamp(velocity.y, 0f, maxVelocity.y));
        transform.position += (Vector3) velocity * Time.deltaTime;

    }
}
