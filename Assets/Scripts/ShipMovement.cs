﻿//Coded by Matthew Woodruff also known as Camwarp

using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public float HyperdriveSpeed = 25.0f;
    private bool HyperDriveToggle = false;
    public PowerBaseScript powerLevelAccess;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {                      
        //Forward Backwards
        if (Input.GetKey("w"))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey("s"))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        //Left Right
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        //Up Down
        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        //Yaw 
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        //Pitch
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        //Rotation
        if (Input.GetKey("q"))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

        if (Input.GetKey("e"))
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
        //HyperSpace
        if (Input.GetKeyDown(KeyCode.H))
        { HyperDriveToggle = !HyperDriveToggle; }

        if (HyperDriveToggle == true)
        {
            transform.Translate(Vector3.forward * HyperdriveSpeed * Time.deltaTime);}
        else
            HyperDriveToggle = false;
    }
}
