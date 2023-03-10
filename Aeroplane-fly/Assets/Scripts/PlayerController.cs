using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables 
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //We get player input here
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //we'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed* verticalInput);  // moving the vechicle by 'speed' in every second

        //we'll turn the vehicle foward
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        
        
    }
}
