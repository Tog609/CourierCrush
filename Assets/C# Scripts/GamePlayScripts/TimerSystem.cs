using System.Collections;
using UnityEngine;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI _timertext;

    private int _timerCount = 90;

    private int _tickInterval = 1;

    [SerializeField] private GameObject _endGamePanel;
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
        while (_timerCount > 0)
        {
            yield return new WaitForSeconds(_tickInterval);
            _timerCount--;
            ShowTimer();
        }
        EndGame();
    }
    private void ShowTimer()
    {
        _timertext.text = $"Timer : {_timerCount}";
    }
    private void EndGame()
    {
        if (_timerCount == 0)
        {
            _endGamePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
