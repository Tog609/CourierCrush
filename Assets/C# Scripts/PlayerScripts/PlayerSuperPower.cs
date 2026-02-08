using UnityEngine;

public class PlayerSuperPower : MonoBehaviour
{
    public bool hasSuperSpeed;
    public bool hasTeleport;

    //private PlayerController _controller;

    [Header("Teleport Settings")]
    public KeyCode teleportKey = KeyCode.R;

    public Vector3 teleportTarget;

    private void Awake()
    {
        //_controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (hasTeleport && Input.GetKeyDown(teleportKey))
        {
            TeleportTo(teleportTarget);
        }
    }

    public void TeleportTo(Vector3 targetPosition)
    {
        transform.position = targetPosition;
        Debug.Log("Teleported to: " + targetPosition);
    }

    public void GivePower(CharactersAvailabilities power)
    {
        switch (power)
        {
            //case CharactersAvailabilities.SuperSpeed:
            //    hasSuperSpeed = true;
            //    _controller.speed += 10f;
            //    Debug.Log("NEW SPEED = " + _controller.speed);
            //    break;

            case CharactersAvailabilities.Teleport:
                hasTeleport = true;
                break;
        }
    }
}