using UnityEngine;

public class CarMoving : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody _rb;

    [SerializeField] private Vector3 _direction;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.MovePosition(transform.position + _direction * _speed * Time.fixedDeltaTime);
    }
}