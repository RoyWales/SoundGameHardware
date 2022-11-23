/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;
using System.Threading;


/**
 * Sample for reading using polling by yourself, and writing too.
 */
public class Arduino_code : MonoBehaviour
{
    public int state = 0;
    public bool b1Pressed = false;

    public SerialController serialController;
    
    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
    }

    // Executed each frame
    void Update()
    {


        //---------------------------------------------------------------------
        // Receive data
        //---------------------------------------------------------------------

        string message = serialController.ReadSerialMessage();

        if (message == null)
            return;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");

        if (message == "button 1 pressed")
        {
            Debug.Log("button 1 pressed");
            b1Pressed = true;
        }
        else
        {
            b1Pressed = false;
        }

        // testing out the buttons and gyroscope
        if (message == "button 2 pressed")
        {
            Debug.Log("button 2 pressed");
            
        }
        

        if (message == "button 3 pressed")
        {
            Debug.Log("button 3 pressed");
            
        }
      

        if (message == "back")
        {
            Debug.Log("back");
            state = 4;
        }

        if (message == "front")
        {
            Debug.Log("front");
            state = 2;
        }

        if (message == "left")
        {
            Debug.Log("left");
            state = 1;
        }

        if (message == "right")
        {
            Debug.Log("right");
            state = 2;
        }


    }
}