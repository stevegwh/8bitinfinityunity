using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopterCat : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0, 0, 0),Vector3.forward, Time.deltaTime * 45);
        
    }
}
