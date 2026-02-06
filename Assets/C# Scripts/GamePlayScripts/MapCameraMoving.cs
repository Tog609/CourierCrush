using UnityEngine;

public class MapCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
