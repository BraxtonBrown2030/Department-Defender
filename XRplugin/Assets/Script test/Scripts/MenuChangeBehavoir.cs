using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu (menuName = "Sence/MenuChangeBehavoir")]
public class MenuChangeBehavoir : ScriptableObject
{
    public int sceneNumber;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
