using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamePanelScripts : MonoBehaviour
{
    public void RestartGameONclick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}