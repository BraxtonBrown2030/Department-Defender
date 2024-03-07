using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class NavDestionSO : ScriptableObject
{
    public GameObject camera;
    public Vector3 destination;
    public void UpdateVaule(Transform obj)
    {
        destination = obj.position;
    }
    
    public void UpdateTransform(Transform obj)
    {
        obj.localPosition = destination;  
    }
    
}
