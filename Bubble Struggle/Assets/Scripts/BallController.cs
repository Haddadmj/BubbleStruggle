using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public Vector2 startForce;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(startForce,ForceMode2D.Impulse);
        
    }
}
