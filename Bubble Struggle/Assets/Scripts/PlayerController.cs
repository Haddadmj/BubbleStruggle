using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody2D _rigidbody2D;
    private float movement;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(movement * speed,_rigidbody2D.velocity.y);

        /*if (Input.GetButton("Fire1"))
        {
            _rigidbody2D.AddForce(new Vector3(0,5f,0),ForceMode2D.Impulse);
        }*/

    }
}
