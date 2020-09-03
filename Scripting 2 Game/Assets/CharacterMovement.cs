using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{

public CharacterController controller;

public Vector3 movement;

public float moveSpeed = 5f, gravity = -9.18f, jumpSpeed = 10f, rotateSpeed = 100f; 
private float yVar; 

public int jumpCountMax = 2; 

private int jumpCount; 

    // Start is called before the first frame update
    void Start()
    {
       

       controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        var vInput = Input.GetAxis("Horizontal")*moveSpeed;
        movement.Set(vInput, yVar, 0);

        var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0, hInput, 0);

        yVar += gravity*Time.deltaTime; 

      
        


        movement = transform.TransformDirection(movement);
        controller.Move(movement*Time.deltaTime);

        



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

        

        

        


        
    }
}
