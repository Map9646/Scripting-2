using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{

private CharacterController controller;

private Vector3 movement;

public float gravity = -9.18f, jumpSpeed = 5f, rotateSpeed = 100f; 
private float yVar; 


public int jumpCountMax = 2; 

private int jumpCount; 

public FloatData normalSpeed, fastSpeed;
private FloatData  moveSpeed;





    // Start is called before the first frame update
    void Start()
    {
       moveSpeed = normalSpeed;

       controller = GetComponent<CharacterController>();

    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {

            moveSpeed = fastSpeed; 
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {

            moveSpeed = normalSpeed;
        }



       
        var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
        movement.Set(vInput, yVar, 0);

       var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0, hInput, 0);  

        yVar += gravity*Time.deltaTime; 

        if(controller.isGrounded && movement.y < 0)
        {
            yVar = -1f; 
            jumpCount = 0; 
        }

       
        

        if(Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {

            yVar = jumpSpeed;
            jumpCount++;  
        }

      
        movement = transform.TransformDirection(movement);
        controller.Move(movement*Time.deltaTime);

    }

    




}






