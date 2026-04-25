using UnityEngine;

public class HorseInteractable : MonoBehaviour, IInteractable
{
    [Header("Horse Settings")]
    [SerializeField] private Transform seatPoint;

    private bool isMounted = false;
    private GameObject mountedPlayer;

    public string GetPromptText()
    {
        if (isMounted)
        {
            return "";
        }

        return "Press E to mount";
    }

    public void Interact(PlayerInteraction playerInteraction)
    {
        if (isMounted)
        {
            return;
        }

        MountPlayer(playerInteraction.gameObject);
        playerInteraction.ClearCurrentInteractable();
    }

    private void MountPlayer(GameObject player)
    {
        mountedPlayer = player;
        isMounted = true;

        CharacterController controller = player.GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.enabled = false;
        }

        PlayerController playerController = player.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.SetMovementEnabled(false);
        }

        player.transform.SetParent(seatPoint);
        player.transform.position = seatPoint.position;
        player.transform.rotation = seatPoint.rotation;

        if (controller != null)
        {
            controller.enabled = true;
        }
    }
}