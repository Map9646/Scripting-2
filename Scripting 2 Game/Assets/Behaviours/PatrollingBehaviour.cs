using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PatrollingBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private int i = 0;
    public List<Vector3> patrolPoints; 
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (agent.pathPending || (agent.remainingDistance < 0.5f)) return;
        agent.destination = patrolPoints(i).position;
        i = (i + 1) % patrolPoints.Count;
        
    }
}
