using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
[CreateAssetMenu]
public class AIBrainBase : ScriptableObject
{
    public float health;
    public float speed;
    public GameObject art; 

    public void Navigate(NavMeshAgent agent)
    {
        
    }



}
