using UnityEngine;
public class TimeManagement : MonoBehaviour 
{
    private int _timeChanger;

    public int IncreaseTimeByPickingPresent()
    {
        _timeChanger = Random.Range(4,10);
        return _timeChanger;
    }
    public int ReduceTimeByHittingObstacle()
    {
        _timeChanger = Random.Range(2,4);
        return _timeChanger;
    }
}
