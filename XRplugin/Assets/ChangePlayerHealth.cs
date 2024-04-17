using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ChangePlayerHealth : MonoBehaviour
{
    public IntData playerHealth;
    public UnityEvent onHealthChange, onhealthzero;

    public void ChangehealthDecrease()
    {
        
        playerHealth.value -= 1;
        
    }
    
    public void Awake()
    {
        playerHealth.value = 10;
    }
    
    public void ChangeHealthIncrease()
    {
        playerHealth.value += 10;
    }

    public void HealthCheck()
    {

        if (playerHealth.value <= 0)
        {
            
            Time.timeScale = 0;
            
            onhealthzero.Invoke();
            
        }
        
    }
    public void changeTimeScale()
    {
        Time.timeScale = 1;
    }
    
}
