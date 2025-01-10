using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float moveSpeed = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveHorizontal * moveSpeed * Time.deltaTime, rb.velocity.y);
    }
}
