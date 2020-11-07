using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Animations : MonoBehaviour
{
    private Animator anim;
    private AnimationClip walk;
    private AnimationClip idle; 
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        anim.SetBool("walk", false);

        anim.SetBool("Idle", true); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
           
            anim.SetBool("Walk", true);
 
        }

    }
        
}

    
