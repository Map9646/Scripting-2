using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBehaviour : MonoBehaviour
{
    public Vector3Data currentSpawnPoint;
    public FloatData health;
    [SerializeField] private CharacterController controls;
        
        
    
    
    private void Start()
    {
        controls = GetComponent<CharacterController>();
        
    }
    
    private void OnEnable()
    {
        transform.position = currentSpawnPoint.value;
        health.value = 100f; 
    }
    private void Update()
    {
        if (health.value <= 0)
        {
            controls.enabled = false;
            transform.position = currentSpawnPoint.value; 
        }
    
        if (transform.position == currentSpawnPoint.value)
        {
            health.value = 100;
            controls.enabled = true; 
        }
            
        

    }

    
    
    
}
    