using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement3x3 : MonoBehaviour
{

    public Arduino_code ArdunioInfo;
    public float moveSpeed = 5.0f;
    public float x, y, z;
    public bool stop = false;
    public Rigidbody rb;

    public bool stopUp = false;
    public bool stopDown = false;
    public bool stopLeft = false;
    public bool stopRight = false;

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
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || ArdunioInfo.b2Pressed) //reset
        {
            transform.position = new Vector3(-2.42f, 0.351f, 2.29f);
            x = -2.42f;
            y = 0.351f;
            z = 2.29f;

        }
        if (Input.GetKeyDown(KeyCode.M) || ArdunioInfo.b3Pressed) //reset
        {
            SceneManager.LoadScene("Map4x4");
        }

        if ((Input.GetKeyDown("up") && !stopUp) || (ArdunioInfo.state == 4 && ArdunioInfo.b1Pressed && !stopUp && !stop))
        {
            z = z - 3.5f;
            transform.position = new Vector3(x, y, z);
            stop = true;

        }
        if ((Input.GetKeyDown("down") && !stopDown) || (ArdunioInfo.state == 3 && ArdunioInfo.b1Pressed && !stopDown && !stop))
        {
            z = z + 3.5f;
            transform.position = new Vector3(x, y, z);
            stop = true;
        }
        if ((Input.GetKeyDown("left") && !stopLeft) || (ArdunioInfo.state == 1 && ArdunioInfo.b1Pressed && !stopLeft && !stop))
        {
            x = x + 3.5f;
            transform.position = new Vector3(x, y, z);
            stop = true;
        }
        if ((Input.GetKeyDown("right") && !stopRight) || (ArdunioInfo.state == 2 && ArdunioInfo.b1Pressed && !stopRight && !stop))
        {

            x = x - 3.5f;
            transform.position = new Vector3(x, y, z);
            stop = true;

        }
    }

    void OnCollisionEnter(Collision other)
    {
        //A--------------------------------
        if (other.gameObject.tag == "A1_2")
        {
            audio.clip = A1;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = true;
            stopRight = true;
            stop = false;
        }
        else if (other.gameObject.tag == "A2_2")
        {
            audio.clip = A2;
            audio.Play();
            stopUp = false;
            stopDown = false;
            stopLeft = true;
            stopRight = true;
            StartCoroutine(Pause());
        }
        else if (other.gameObject.tag == "A3_2")
        {
            audio.clip = A3;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = true;
            stopRight = false;
            stop = false;
        }

        //B--------------------------------
        else if (other.gameObject.tag == "B1_2")
        {
            audio.clip = B1;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = true;
            stopRight = false;
            stop = false;
        }
        else if (other.gameObject.tag == "B2_2")
        {
            audio.clip = B2;
            audio.Play();
            stopUp = false;
            stopDown = false;
            stopLeft = true;
            stopRight = true;
            StartCoroutine(Pause());
            
        }
        else if (other.gameObject.tag == "B3_2")
        {
            audio.clip = B3;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = false;
            stopRight = false;
            StartCoroutine(Pause());
        }

        //C--------------------------------
        else if (other.gameObject.tag == "C1_2")
        {
            audio.clip = C1;
            audio.Play();
            stopUp = false;
            stopDown = true;
            stopLeft = false;
            stopRight = true;
            stop = false;
        }
        else if (other.gameObject.tag == "C2_2")
        {
            audio.clip = C2;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = true;
            stopRight = true;
            stop = false;
        }
        else if (other.gameObject.tag == "C3_2")
        {
            audio.clip = C3;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = false;
            stopRight = true;
            stop = false;
        }


    }
    public IEnumerator Pause()
    {
        
        yield return new WaitForSeconds(1f);
        stop = false;
    }
}
