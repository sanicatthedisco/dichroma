using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float dx, ddx, speed;
    float friction;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        friction = 5;
        speed = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dx = Input.GetAxis("Horizontal");
        ddx += dx;

        Vector2 movement = new Vector2(dx, rb.velocity.y);

        rb.velocity = movement;
    }
}
