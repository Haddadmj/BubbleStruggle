using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public Vector2 startForce;
    public GameObject nextBall;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(startForce,ForceMode2D.Impulse);
        
    }

    public void Split()
    {
        if (nextBall != null)
        {
            var ball1 = Instantiate(nextBall, _rigidbody2D.position + Vector2.right / 4f, Quaternion.identity);
            var ball2 =Instantiate(nextBall, _rigidbody2D.position + Vector2.left / 4f, Quaternion.identity);
            
            ball1.GetComponent<BallController>().startForce = new Vector2(2f,5f);
            ball2.GetComponent<BallController>().startForce = new Vector2(-2f,5f);
        }
        
        Destroy(gameObject);
    }
}
