using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public static bool IsFired;
    public float chainSpeed = 2f;

    private Transform _player;

    public Vector3 displacement;

    // Start is called before the first frame update
    void Start()
    {
        IsFired = false;
        _player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }

        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * (chainSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = _player.position - displacement;
            transform.localScale = new Vector3(1f, 0, 1f);
        }
    }
}