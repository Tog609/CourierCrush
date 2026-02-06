using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleHitImplementation : MonoBehaviour
{
    [SerializeField] private TimeManagement _timerManager ;

    [SerializeField] private TimerSystem _timerSystem;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))  
        {
            _timerSystem.TimerCount -= _timerManager.ReduceTimeByHittingObstacle();
        }
    }
}
