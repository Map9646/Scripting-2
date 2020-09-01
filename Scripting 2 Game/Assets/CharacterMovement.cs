using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

public CharacterController controller;

public Vector3 movement;



    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(movement*Time.deltaTime);
        


        
    }
}
