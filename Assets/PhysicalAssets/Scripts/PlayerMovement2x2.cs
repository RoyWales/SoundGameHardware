using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2x2 : MonoBehaviour
{

    public Arduino_code ArdunioInfo;
   
    public float moveSpeed = 5.0f;

    public Rigidbody rb;

    
    public bool stopUp = false;
    public bool stopDown = false;
    public bool stopLeft = false;
    public bool stopRight = false;

    Vector3 movement;

    public AudioClip A1;
    public AudioClip A2;

    public AudioClip B1;
    public AudioClip B2;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKeyDown("up") && !stopUp) || (ArdunioInfo.state == 4 && ArdunioInfo.b1Pressed && !stopUp))
        {
           
            transform.Translate(0, 0, -50f * Time.deltaTime);
           
        }
        if ((Input.GetKeyDown("down") && !stopDown) || (ArdunioInfo.state == 3 && ArdunioInfo.b1Pressed && !stopDown))
        {
            transform.Translate(0, 0, 50f * Time.deltaTime);
            
        }
        if ((Input.GetKeyDown("left") && !stopLeft) || (ArdunioInfo.state == 1 && ArdunioInfo.b1Pressed && !stopLeft))
        {
          
            transform.Translate(50f * Time.deltaTime, 0, 0);
           
        }
        if ((Input.GetKeyDown("right") && !stopRight) || (ArdunioInfo.state == 2 && ArdunioInfo.b1Pressed && !stopRight))
        {
           
            transform.Translate(-50f* Time.deltaTime, 0, 0);
          
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //A--------------------------------
        if (other.gameObject.tag == "A1_1")
        {
            audio.clip = A1;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = true;
            stopRight = false;
        }

        if (other.gameObject.tag == "A2_1")
        {
            audio.clip = A2;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = true;
            stopRight = true;
        }

        //B--------------------------------
        if (other.gameObject.tag == "B1_1")
        {
            audio.clip = B1;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = false;
            stopRight = true;
        }
        if (other.gameObject.tag == "B2_1")
        {
            audio.clip = B2;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = false;
            stopRight = true;
        }
    }

}
