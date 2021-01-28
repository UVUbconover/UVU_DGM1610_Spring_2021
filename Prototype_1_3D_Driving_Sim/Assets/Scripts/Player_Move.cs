using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    //Access Modifier, Data Type, Name
    private float speed = 18.0f;
    private float turnSpeed = 30.0f; 

    private float hInput;
    private float vInput;

    // Update is called once per frame
    void Update()
    {
        // Gathers inputs for the controls
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        // Controls player movement foward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vInput);
        //Controls player movement left and right
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}
