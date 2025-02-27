using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    Rigidbody2D rb;
    [HideInInspector]
    public Vector2 moveDir;

    [HideInInspector]
    public Vector2 lastMoveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // default lastMoveDir to right
        lastMoveDir = new Vector2(1, 0);
    }

    void Update()
    {
        InputManagement();
    }

    void FixedUpdate()
    {
        Move();
    }

    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;

        if (moveDir != Vector2.zero)
        {
            lastMoveDir = moveDir;
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
