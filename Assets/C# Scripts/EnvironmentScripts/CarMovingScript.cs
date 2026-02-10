using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovingScript : MonoBehaviour
{
    [SerializeField] private float _speed = 9f;

    public void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(new Vector3(1,0,0) * Time.deltaTime * _speed);
    }
}
