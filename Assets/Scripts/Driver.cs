using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private float moveSpeed = 15;
    private float steerSpeed = 90;

    private float verticalInput;
    private float rotationalInput;


    // Update is called once per frame
    void Update()
    {
        movement();
    }


    private void movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        rotationalInput = Input.GetAxis("Horizontal");


        float steerAmount = rotationalInput * verticalInput * steerSpeed * Time.deltaTime;
        float moveAmount = verticalInput * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            moveSpeed = 30;
        }
        else
        {
            moveSpeed = 15;
        }
    }
}
