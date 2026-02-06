using System.Collections;
using TMPro;
using UnityEngine;

public class PickUpPresent : MonoBehaviour
{
    private PresentData _data = new PresentData();

    [SerializeField] private DeliverySystem _deliverySystem;

    [SerializeField] private TimerSystem _timerSystem;

    [SerializeField] private TimeManagement _timeManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Delivery"))
        {
            Destroy(other.gameObject);
            _data.PickItem();
            _deliverySystem.SpawnDestroyPosition();
        }
        else if (other.CompareTag("DeliveryArea") && _data.IsPicked)
        {
            Destroy(other.gameObject);
            _data.UnpickItem();
            _deliverySystem.Spawn();
            _timerSystem.TimerCount += _timeManager.IncreaseTimeByPickingPresent();
        }
    }
}