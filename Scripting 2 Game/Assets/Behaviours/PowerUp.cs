using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public FloatData powerData;
    public float powerUpLevel = 0.1f;
    
    private void OnTriggerEnter(Collider other)
    {
        powerData.value += powerUpLevel; 
    }
}

    

