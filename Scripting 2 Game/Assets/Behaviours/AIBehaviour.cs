using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehaviour : MonoBehaviour
{
    private WaitForFixedUpdate wfs = new WaitForFixedUpdate();
    public Transform player;
    private bool canNav = true;
    private NavMeshAgent agent; 
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        canNav = true;
        while (canNav)
        {
            yield return wfs;
            agent.destination = player.position;
        }
            
        
    }

    private void OnTriggerExit(Collider other)
    {
        canNav = false; 
    }
}
