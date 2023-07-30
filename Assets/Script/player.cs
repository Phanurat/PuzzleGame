using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private float horizontalMove;
    private bool moveRight;
    private bool moveLeft;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }

    void Update()
    {
        Movement();
    }
    public void PointerDownLeft()
    {
        moveLeft = true;
        //moveRight = false;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
        //moveLeft = false;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }

    void Movement()
    {
        if(moveLeft)
        {
            horizontalMove = -speed;
        }
        else if(moveRight)
        {
            horizontalMove = speed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}

