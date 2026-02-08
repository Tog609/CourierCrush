using System.Collections;
using UnityEngine;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI _timertext;

    private int _timerCount = 90;

    public int timerCountToShow;

    private int _tickInterval = 1;

    [SerializeField] private EndGamePanelScripts _endGamePanel;
    public int TimerCount
    {
        get { return _timerCount; }
        set { _timerCount = value; }
    }

    private void Start()
    {
          StartCoroutine(GetTimer());
          ShowTimer();

    }
    private IEnumerator GetTimer()
    {
        timerCountToShow = 0;

        while (_timerCount > 0)
        {
            yield return new WaitForSeconds(_tickInterval);

            _timerCount--;
            timerCountToShow++;

            ShowTimer();
        }

        EndGame();
    }
    private void ShowTimer()
    {
        _timertext.text = $"Timer : {_timerCount}";
    }
    public void EndGame()
    {
        _endGamePanel.gameObject.SetActive(true);
        _endGamePanel.ShowText();
        Time.timeScale = 0f;
    }
}
