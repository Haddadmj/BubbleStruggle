using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        _rigidbody2D.velocity = new Vector2(movement * speed, _rigidbody2D.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(GameObject.Find("Chain"));
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}