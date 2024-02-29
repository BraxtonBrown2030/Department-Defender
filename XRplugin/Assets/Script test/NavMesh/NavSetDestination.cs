using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class NavSetDestination : MonoBehaviour
{
    [Tooltip("Current objects NavMeshAgent")]
    public NavMeshAgent navmesh;
    [Tooltip("End destination of current objects movement")]
    public Transform movePosition;

    public bool move;
    public UnityEvent startmove, start;
    private WaitForFixedUpdate waitFFU;
    public Transform transformobj;
    
    void Awake()
    {
        waitFFU = new WaitForFixedUpdate();
        navmesh = GetComponent<NavMeshAgent>();
        
    }

   public void StartMovemnt()
   {
       move = true;
        StartCoroutine(MoveToDestianation());
        start.Invoke();

    }
    

    public IEnumerator MoveToDestianation()
    {


        while (move == true)
        {
            yield return waitFFU;
            navmesh.destination = movePosition.position;
            
        }
       
    }

    public void Resstart()
    {
        StartCoroutine(MoveToDestianation());
    }

    public void StopMovement()
    {

        move = false;
        navmesh.speed = 0;
        movePosition = transformobj;

    }
    
}
