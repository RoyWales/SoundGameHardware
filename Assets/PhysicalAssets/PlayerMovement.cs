using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5.0f;

    public Rigidbody rb;

    Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + (movement * -1) * moveSpeed * Time.fixedDeltaTime);
    }
}
