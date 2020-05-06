using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody2D _rigidbody2D;
    private Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"),0);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + Vector3.right * movement * (speed * Time.fixedDeltaTime));
    }
}
