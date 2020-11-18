using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWithBrains : MonoBehaviour
{
    private NavMeshAgent agent;
    public AIBrainBase aiBrain; 
    public Transform player;
    private int i = 0; 
    public List<brainUpgrades>
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        aiBrain.Navigate(agent);
    }

    private void OnTriggerEnter(Collider other)
    {
        aiBrain = brainUpgrades[i];
    }
}
