using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EllipticOrbit : MonoBehaviour
{
    [SerializeField] private float a;
    [SerializeField] private float b;
    [SerializeField] private float speed;
    private float x;
    private float y;
    [SerializeField] private float angle;
    private float X;
    private float Y;
    
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        X = x + (a * (float) Math.Cos(angle * .005f));
        Y = y + (b * (float) Math.Sin(angle * .005f));
        transform.position = new Vector3(X, Y, 0);
    }
}
