using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleHitImplementation : MonoBehaviour
{
     private TimeManagement _timerManager ;

     private TimerSystem _timerSystem;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))  
        {
            _timerSystem.TimerCount -= _timerManager.ReduceTimeByHittingObstacle();
        }
    }
    private void Awake()
    {
        if (!_timerManager) _timerManager = FindObjectOfType<TimeManagement>();
        if (!_timerSystem) _timerSystem = FindObjectOfType<TimerSystem>();
    }

}
