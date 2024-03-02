using UnityEngine;
using UnityEngine.Events;

public class QuitAplacation : MonoBehaviour
{
    public UnityEvent quitEvent;
    
    public void Quit()
    {
        Application.Quit();
        quitEvent.Invoke();
    }
}
