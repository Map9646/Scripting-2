using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Instancer : MonoBehaviour
{

    public GameObject prefab; 

    

    // Start is called before the first frame update
    void Start()
    {
        
        var location = transform.position;
        Instantiate( prefab, location, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
