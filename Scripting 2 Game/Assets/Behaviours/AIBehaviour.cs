using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehaviour : MonoBehaviour
{
    private WaitForFixedUpdate wfs = new WaitForFixedUpdate();
    public Transform player;
    private NavMeshAgent agent;
    public bool canHunt, canPatrol;
    public List<Transform> patrolPoints; 
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = player.position;
        var distance = agent.remainingDistance;
        while (distance <= 0.25f)
        {
            distance = agent.remainingDistance;
            yield return wfs;
            
        }
            
        yield return new WaitForSeconds(2f);

        StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
    }
    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        
    }
    
    private int i = 0;
    private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
            yield return wfs;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    } 
}

    

