using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class ChangeSence : MonoBehaviour
{
    public UnityEvent changeEvent;
    
    public void Change()
    {
        
        SceneManager.LoadScene("BasicScene");
        changeEvent.Invoke();
    }
    
    
}
