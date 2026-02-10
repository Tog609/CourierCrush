using UnityEngine;
using System.Collections;

[System.Serializable]
public struct SpawnPoint
{
    public Vector3 position;
    public Vector3 rotation;
}

public class CarManagerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _car;

    [SerializeField] private SpawnPoint[] _spawnPoints;

    [SerializeField] private float _spawnInterval = 3f;
    [SerializeField] private float _lifeTime = 16f;

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnCars();
            yield return new WaitForSeconds(_spawnInterval);
        }
    }

    private void SpawnCars()
    {
        foreach (var point in _spawnPoints)
        {
            Quaternion rot = Quaternion.Euler(point.rotation);
            GameObject car = Instantiate(_car, point.position, rot);
            Destroy(car, _lifeTime);
        }
    }
}