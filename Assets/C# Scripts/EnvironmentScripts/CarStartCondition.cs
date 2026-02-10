using UnityEngine;

public class CarStartCondition : MonoBehaviour
{
    [SerializeField] private Material[] _materials;

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        SetRandomColor();
    }
    private void SetRandomColor()
    {
        int indexx = Random.Range(0, _materials.Length);
        _material.color = _materials[indexx].color;
    }
}