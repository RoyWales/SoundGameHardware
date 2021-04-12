using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5.0f;

    public Rigidbody rb;

    public bool stopUp = false;
    public bool stopDown = false;
    public bool stopLeft = false;
    public bool stopRight = false;

    Vector3 movement;

    public AudioClip A1;
    public AudioClip A2;
    public AudioClip A3;
    public AudioClip A4;

    public AudioClip B1;
    public AudioClip B2;
    public AudioClip B3;
    public AudioClip B4;
 
    public AudioClip C2;
    public AudioClip C3;
    public AudioClip C4;

    public AudioClip D1;
    public AudioClip D2;
    public AudioClip D3;
    public AudioClip D4;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") && !stopUp)
        {
            transform.Translate(0, 0, -2.5f);
        }
        if (Input.GetKeyDown("down") && !stopDown)
        {
            transform.Translate(0, 0, 2.5f);
        }
        if (Input.GetKeyDown("left") && !stopLeft)
        {
            transform.Translate(2.5f, 0, 0);
        }
        if (Input.GetKeyDown("right") && !stopRight)
        {
            transform.Translate(-2.5f, 0, 0);
        }
    }
    
    void OnCollisionEnter(Collision other)
    {
        //A--------------------------------
        if (other.gameObject.tag == "A1_3")
        {
            audio.clip = A1;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = true;
            stopRight = false;
        }
        

        else if (other.gameObject.tag == "A2_3")
        {
            audio.clip = A2;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = true;
            stopRight = true;
        }


        else if (other.gameObject.tag == "A3_3")
        {
            audio.clip = A3;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = true;
            stopRight = true;
        }


        else if (other.gameObject.tag == "A4_3")
        {
            audio.clip = A4;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = true;
            stopRight = false;
        }


        //B--------------------------------
        else if(other.gameObject.tag == "B1_3")
        {
            audio.clip = B1;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = false;
            stopRight = true;
        }


        else if(other.gameObject.tag == "B2_3")
        {
            audio.clip = B2;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = true;
            stopRight = false;
        }


        else if(other.gameObject.tag == "B3_3")
        {
            audio.clip = B3;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = true;
            stopRight = false;
        }


        else if(other.gameObject.tag == "B4_3")
        {
            audio.clip = B4;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = false;
            stopRight = false;
        }


        //C--------------------------------
        else if(other.gameObject.tag == "C2_3")
        {
            audio.clip = C2;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = false;
            stopRight = false;
        }


        else if(other.gameObject.tag == "C3_3")
        {
            audio.clip = C3;
            audio.Play();
            stopUp = false;
            stopDown = false;
            stopLeft = false;
            stopRight = false;
        }

        else if(other.gameObject.tag == "C4_3")
        {
            audio.clip = C4;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = false;
            stopRight = false;
        }


        //D--------------------------------
        else if(other.gameObject.tag == "D1_3")
        {
            audio.clip = D1;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = true;
            stopRight = true;
        }


        else if(other.gameObject.tag == "D2_3")
        {
            audio.clip = D2;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = false;
            stopRight = true;
        }


        else if(other.gameObject.tag == "D3_3")
        {
            audio.clip = D3;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = false;
            stopRight = true;
        }


        else if(other.gameObject.tag == "D4_3")
        {
            audio.clip = D4;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = false;
            stopRight = true;
        }

    }
}
