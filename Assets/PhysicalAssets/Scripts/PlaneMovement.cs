using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{

    public float planeMoveSpeed = 2.0f;

    public Rigidbody rb;

    Vector3 planeMovement;

    // Update is called once per frame
    void Update()
    {
        //Input
        if (Input.GetKeyDown(KeyCode.Q))
        {
            planeMovement.y--;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            planeMovement.y = 0;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            planeMovement.y++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            planeMovement.y = 0;
        }
    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + (planeMovement * -1) * planeMoveSpeed * Time.fixedDeltaTime);
    }
}
