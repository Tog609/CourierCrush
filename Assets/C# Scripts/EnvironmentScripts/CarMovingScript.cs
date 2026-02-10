using UnityEngine;

public class CarMovingScript : MonoBehaviour
{
    [SerializeField] private float _speed = 9f;
    [SerializeField] private float _speedStep = 1f;
    [SerializeField] private float _interval = 5f;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _interval)
        {
            _speed += _speedStep;
            _timer = 0f;
        }

        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
}