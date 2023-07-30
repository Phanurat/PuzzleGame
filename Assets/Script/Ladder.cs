using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D col;
    public float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        // ตรวจสอบว่า Player อยู่บนพื้นหรือไม่
        bool isGrounded = Physics2D.IsTouchingLayers(col, LayerMask.GetMask("Ground"));

        // เมื่อกดปุ่มลง (S บนแป้นพิมพ์หรือปุ่มล่างในจอแสดงผลสัมผัส) และ Player อยู่บนพื้น
        if (Input.GetKeyDown(KeyCode.S) && isGrounded)
        {
            // ทำการเคลื่อนที่ลงไปด้านล่าง
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
    }
}

