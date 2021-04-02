using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private AudioSource A1_3;//Map.3 //A1 Audio Clip Plays on each square.

    public float moveSpeed = 5.0f;

    public Rigidbody rb;

    Vector3 movement;

    void Start()
    {
        A1_3 = GameObject.FindObjectOfType<AudioSource>();
    }

    void OnCollisionEnter()
    {
        Debug.Log("Hit");
        A1_3.Play();//A1 Audio Clip Plays on each square.
    }

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
