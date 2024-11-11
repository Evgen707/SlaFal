using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllre : MonoBehaviour
{
    public float speed = 1f; //Скорость движения
    public float smoth = 5.0f; //
    public float tiltAngle = 60.0f; //
    public Joystick joystick;
    private Vector2 moveVelocity;

    Rigidbody2D rb;

    

    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //moveVelocity.x = joystick.Horizontal;

        moveVelocity.x = joystick.Horizontal;

        // Движение по горизонтали
        // float movement = joystick.Horizontal;    //Input.GetAxis("Horizontal");
        //  transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;


        rb.MovePosition(rb.position + moveVelocity * speed * Time.deltaTime);

        if (moveVelocity.x < 0)
        {
            Quaternion rot = transform.rotation;
            rot.y = 0;
            transform.rotation = rot;
        }

        if (moveVelocity.x > 0)
        {
            Quaternion rot = transform.rotation;
            rot.y = 180;
            transform.rotation = rot;
        }



    }
    void FixedUpdate()
    {
         
    }

}

