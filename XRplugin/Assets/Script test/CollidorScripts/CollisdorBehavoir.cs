using UnityEngine;
using UnityEngine.Events;

public class CollisdorBehavoir : MonoBehaviour
{
    private Collider colliderObj;
    public UnityEvent startEvent, triggerEnterEvent;
    public new string tag;
    protected virtual void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
        startEvent.Invoke();
    }
    
    protected virtual void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag(tag))
        {
            triggerEnterEvent.Invoke();
            
        }
        
    }
    
    public void NameCOllider()
    {
        Debug.Log(colliderObj.name);
    }
  
}
