using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerBehaviour : LivingObject
{
    /* Variables */
    private Rigidbody2D rb;
    float horizontalInput, verticalInput;
    public float moveSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput, verticalInput) * moveSpeed;
    }
}
