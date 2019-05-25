using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float dx, ddx, speed, maxdx;
    float friction;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        friction = 3;
        speed = 8;
        maxdx = 12;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ddx = Input.GetAxis("Horizontal") * speed;
        dx += ddx;

        if (dx > 0) {
            dx -= friction;
            if (dx < 0) {
                dx = 0;
            }
            if (dx > maxdx) {
                dx = maxdx;
            }
        } else if (dx < 0) {
            dx += friction;
            if (dx > 0) {
                dx = 0;
            }
            if (dx < -maxdx)
            {
                dx = -maxdx;
            }
        }

        Vector2 movement = new Vector2(dx, rb.velocity.y);

        rb.velocity = movement;
    }
}
