using UnityEngine;

public class CarCreation : MonoBehaviour
{
    private Material _material;

    [SerializeField] private Color[] _color;

    void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        SetRandomColor();
    }

    private void SetRandomColor()
    {
        int index = Random.Range(0, _color.Length);
        _material.color = _color[index]; 
    }
}