using UnityEngine;

public class GetSuperPower : MonoBehaviour
{
    [SerializeField] private CharactersAvailabilities superPower;

    private void Update()
    {
        Rotate();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerSuperPower p = other.GetComponent<PlayerSuperPower>();
            if (p != null)
            {
                p.GivePower(superPower);
            }
            Destroy(gameObject); 
        }
    }
    private void Rotate()
    {
        transform.Rotate(0, 100f * Time.deltaTime, 0);
    }
}