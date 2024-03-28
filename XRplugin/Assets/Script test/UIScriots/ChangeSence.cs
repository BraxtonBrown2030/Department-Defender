using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class ChangeSence : MonoBehaviour
{
    public void Change(int hightvalue)
    {
        SceneManager.LoadScene(hightvalue);
    }
}