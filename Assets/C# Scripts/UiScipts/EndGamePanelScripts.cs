using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamePanelScripts : MonoBehaviour
{
    [SerializeField] private TimerSystem _timerSystem;

    [SerializeField] private TMPro.TextMeshProUGUI _countSecText;

    //[SerializeField] private TMPro.TextMeshProUGUI _numberOfDeliviries;

    public void RestartGameONclick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ShowText()
    {
        _countSecText.text = "Final Time : " + _timerSystem.timerCountToShow.ToString();
    }
    
}
public class Bear
{

}