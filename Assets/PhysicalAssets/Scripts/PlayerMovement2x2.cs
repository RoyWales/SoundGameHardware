using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement2x2 : MonoBehaviour
{

    public Arduino_code ArdunioInfo;
    public float moveSpeed = 5.0f;
    public float x,y,z;
    public Rigidbody rb;
    public bool stop = false;
    
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
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) || ArdunioInfo.b2Pressed) //reset
        {
            transform.position = new Vector3(3.35f, 0.351f, 1.44f);
            x = 3.35f;
            y = 0.351f;
            z = 1.44f;

        }
        if (Input.GetKeyDown(KeyCode.M) || ArdunioInfo.b3Pressed) //reset
        {
            SceneManager.LoadScene("Map3x3");
        }

        if ((Input.GetKeyDown("up") && !stopUp) || (ArdunioInfo.state == 4 && ArdunioInfo.b1Pressed && !stopUp && !stop))
        {
            z = z - 5;
            transform.position = new Vector3(x, y, z);
            stop = true;
           
        }
        if ((Input.GetKeyDown("down") && !stopDown) || (ArdunioInfo.state == 3 && ArdunioInfo.b1Pressed && !stopDown && !stop))
        {
            z = z + 5;
            // transform.Translate(0, 0, 50f * Time.deltaTime);
            transform.position = new Vector3(x, y, z);
            stop = true;
        }
        if ((Input.GetKeyDown("left") && !stopLeft) || (ArdunioInfo.state == 1 && ArdunioInfo.b1Pressed && !stopLeft && !stop))
        {
            x = x + 5;
            //  transform.Translate(50f * Time.deltaTime, 0, 0);
            transform.position = new Vector3(x, y, z);
            stop = true;
        }
        if ((Input.GetKeyDown("right") && !stopRight) || (ArdunioInfo.state == 2 && ArdunioInfo.b1Pressed && !stopRight && !stop))
        {
            
            
            // transform.Translate(-50f* Time.deltaTime, 0, 0);
            x = x - 5;
            transform.position = new Vector3(x, y, z);
            stop = true;
           
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
            stop = false;
        }

        if (other.gameObject.tag == "A2_1")
        {
            audio.clip = A2;
            audio.Play();
            stopUp = true;
            stopDown = true;
            stopLeft = true;
            stopRight = true;
            stop = false;
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
            stop = false;
        }
        if (other.gameObject.tag == "B2_1")
        {
            audio.clip = B2;
            audio.Play();
            stopUp = true;
            stopDown = false;
            stopLeft = false;
            stopRight = true;
            stop = false;
        }
    }
    public IEnumerator Pause()
    {
        yield return new WaitForSeconds(5f);
    }

}
