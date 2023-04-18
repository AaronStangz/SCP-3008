using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Staff : MonoBehaviour
{
    [SerializeField]
    private GameObject[] points;
    [SerializeField]
    private NavMeshAgent agent;
    [SerializeField]
    float dist = 0.1f;

    private int currPoint;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = true;
        currPoint = 0;
        agent.destination = points[currPoint].transform.position;
    }

    private void Update()
    {
        if(Vector3.Distance(this.transform.position,points[currPoint].transform.position)<=dist)
        {
            iterate();
        }
    }
    void iterate()
    {
        if(currPoint<points.Length-1)
        {
            currPoint++;
        }
        else
        {
            currPoint = 0;
        }
        agent.destination = points[currPoint].transform.position;
    }
}
