using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemycontolor : MonoBehaviour
{
   
    private NavMeshAgent agent;
    public Transform target;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {


    }

    void Update()
    {

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
        rb = GetComponent<Rigidbody>();
    }
}