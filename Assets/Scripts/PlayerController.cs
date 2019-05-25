using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHor = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHor, rb.velocity.y);

        rb.velocity = movement;
    }
}
