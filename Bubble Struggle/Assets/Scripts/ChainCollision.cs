using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print($"{other.gameObject.name} Triggered it" );
        Chain.IsFired = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        print($"{other.gameObject.name} Entered it");
    }
}
