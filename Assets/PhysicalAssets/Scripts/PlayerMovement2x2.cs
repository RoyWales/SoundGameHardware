using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2x2 : MonoBehaviour
{

    public float moveSpeed = 5.0f;

    public Rigidbody rb;

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
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0, 0, -5.3f);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0, 0, 5.3f);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Translate(5.3f, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(-5.3f, 0, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //A--------------------------------
        if (other.gameObject.tag == "A1_1")
        {
            audio.clip = A1;
            audio.Play();
        }
        if (other.gameObject.tag == "A2_1")
        {
            audio.clip = A2;
            audio.Play();
        }

        //B--------------------------------
        if (other.gameObject.tag == "B1_1")
        {
            audio.clip = B1;
            audio.Play();
        }
        if (other.gameObject.tag == "B2_1")
        {
            audio.clip = B2;
            audio.Play();
        }
    }
}
