using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{

public CharacterController controller;

public Vector3 movement;

public float moveSpeed = 5f;

public float gravity = 2f;

public float jumpSpeed = 40f;


    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(movement*Time.deltaTime);
        
        movement.y -= gravity;

        movement.x = Input.GetAxis("Horizontal")*moveSpeed;

        if(Input.GetButtonDown("Jump"))
        {

            movement.y = jumpSpeed; 
        }

        

        


        
    }
}
