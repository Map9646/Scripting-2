using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class ImageBehaviour : MonoBehaviour
{
    public Image healthBar;

    public FloatData health; 
    
    
    
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health.value / 100;
        healthBar.color = Color.green;

        //if (health.value >= 40)
        //{
            //healthBar.color = Color.yellow;
            
        //}

        //if (health.value >= 10)
        //{
            //healthBar.color = Color.red; 
        //}
    }
}
