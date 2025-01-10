using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float moveSpeed = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y + moveSpeed) * Time.deltaTime);
    }
}
