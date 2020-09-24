using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimMouseLocationBehaviour : MonoBehaviour
{
    private Camera cam;

    public Vector3Data locationData;

    public Transform location; 
    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        

    }

    
}
