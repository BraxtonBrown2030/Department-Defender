using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavSetUpdateScript : MonoBehaviour
{
    [Tooltip("Current objects NavMeshAgent")]
    public NavMeshAgent navmesh;
    [Tooltip("End destination of current objects movement")]
    public Transform movePosition;

    public FloatData moveSpeed;

    public BoolData moveSo;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (moveSo.onOff == true)
        {
            navmesh.speed = 1.5f;
            navmesh.destination = movePosition.position;
            
        }

        if (moveSo.onOff == false)
        {

            navmesh.speed = 0;

        }
        
        
    }
    public void UpdateSpeed(float speed)
    {
        navmesh.speed = speed;
    }
}
