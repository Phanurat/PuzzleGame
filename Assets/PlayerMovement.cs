using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // ความเร็วของ Player
    private Rigidbody2D rb;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // กลับด้านหน้า Player เมื่อถอยหลัง
        }
        else if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // กลับด้านหลัง Player เมื่อเดินหน้า
        }
    }
}
