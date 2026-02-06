using System.Collections.Generic;
using UnityEngine;

public class DeliverySystem : MonoBehaviour
{
    [SerializeField] private Vector3 _spawnPosition;

    [SerializeField] private List<Vector3> _destroyPosition;

    [SerializeField] private GameObject _deliveryObject;

    [SerializeField] private GameObject _deliveryArea;

    private void Start()
    {
        Spawn();
    }
    public void Spawn()
    {
        Instantiate(_deliveryObject, _spawnPosition, transform.rotation.normalized);
    }
    public void SpawnDestroyPosition()
    {
        int index = Random.Range(0, _destroyPosition.Count);
        Instantiate(_deliveryArea.gameObject, _destroyPosition[index], transform.rotation);
    }
}