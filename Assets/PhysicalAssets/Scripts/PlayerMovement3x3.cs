using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3x3 : MonoBehaviour
{

    public float moveSpeed = 5.0f;

    public Rigidbody rb;

    Vector3 movement;

    public AudioClip A1;
    public AudioClip A2;
    public AudioClip A3;

    public AudioClip B1;
    public AudioClip B2;
    public AudioClip B3;

    public AudioClip C1;
    public AudioClip C2;
    public AudioClip C3;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0, 0, -3.5f);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0, 0, 3.5f);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Translate(3.5f, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(-3.5f, 0, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //A--------------------------------
        if (other.gameObject.tag == "A1_2")
        {
            audio.clip = A1;
            audio.Play();
        }
        if (other.gameObject.tag == "A2_2")
        {
            audio.clip = A2;
            audio.Play();
        }
        if (other.gameObject.tag == "A3_2")
        {
            audio.clip = A3;
            audio.Play();
        }

        //B--------------------------------
        if (other.gameObject.tag == "B1_2")
        {
            audio.clip = B1;
            audio.Play();
        }
        if (other.gameObject.tag == "B2_2")
        {
            audio.clip = B2;
            audio.Play();
        }
        if (other.gameObject.tag == "B3_2")
        {
            audio.clip = B3;
            audio.Play();
        }

        //C--------------------------------
        if (other.gameObject.tag == "C1_2")
        {
            audio.clip = C1;
            audio.Play();
        }
        if (other.gameObject.tag == "C2_2")
        {
            audio.clip = C2;
            audio.Play();
        }
        if (other.gameObject.tag == "C3_2")
        {
            audio.clip = C3;
            audio.Play();
        }


    }
}
