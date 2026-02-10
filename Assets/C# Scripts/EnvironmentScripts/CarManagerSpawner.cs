using UnityEngine;
using System.Collections;

public class CarManagerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _car;

    [SerializeField] private Vector3 _spawnPosA;
    [SerializeField] private Vector3 _spawnPosB;

    [SerializeField] private Vector3 _rotationA;
    [SerializeField] private Vector3 _rotationB;

    [SerializeField] private float _spawnInterval = 3f;
    [SerializeField]
    private float _lifeTime = 16f;

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
        Quaternion rotA = Quaternion.Euler(_rotationA);
        Quaternion rotB = Quaternion.Euler(_rotationB);

        GameObject carA = Instantiate(_car, _spawnPosA, rotA);
        GameObject carB = Instantiate(_car, _spawnPosB, rotB);

        Destroy(carA, _lifeTime);
        Destroy(carB, _lifeTime);
    }
}