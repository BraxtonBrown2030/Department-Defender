using UnityEngine;
using UnityEngine.Events;

public class CollisdorBehavoir : MonoBehaviour
{
    private Collider colliderObj;
    public UnityEvent startEvent, triggerEnterEvent;
    protected virtual void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
        startEvent.Invoke();
    }
    
    protected virtual void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    
    public void NameCOllider()
    {
        Debug.Log(colliderObj.name);
    }
}
