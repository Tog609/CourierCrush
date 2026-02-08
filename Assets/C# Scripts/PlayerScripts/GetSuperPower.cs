using UnityEngine;

public class GetSuperPower : MonoBehaviour
{
    public CharactersAvailabilities superPower;

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
}