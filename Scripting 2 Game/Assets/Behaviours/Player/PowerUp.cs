using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public FloatData health;
    public FloatData maxHealth; 
    public float powerUpLevel = 0.1f;
    
    private void OnTriggerEnter(Collider other)
    {
        health.value += powerUpLevel; 
    }
    
    private void Update()
    {
        if (health.value >= 100)
        {
            health.value = maxHealth.value; 
        }
    }
}

    

