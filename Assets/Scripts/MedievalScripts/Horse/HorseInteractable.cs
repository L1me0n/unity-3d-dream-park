using UnityEngine;

public class HorseInteractable : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] private HorseController horseController;

    [Header("Horse Settings")]
    [SerializeField] private Transform seatPoint;
    [SerializeField] private Transform standPoint;

    private bool isMounted = false;
    private GameObject mountedPlayer;

    private void Awake()
    {
        if (horseController == null)
        {
            horseController = GetComponent<HorseController>();
        }
    }

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
            DismountPlayer();
            horseController.SetMounted(false);
        }
        else
        {
            MountPlayer(playerInteraction.gameObject);
            horseController.SetMounted(true);
        }
        
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

    private void DismountPlayer()
    {
        if (!isMounted || mountedPlayer == null)
        {
            return;
        }

        isMounted = false;

        CharacterController controller = 
            mountedPlayer.GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.enabled = false;
        }

        PlayerController playerController = 
            mountedPlayer.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.SetMovementEnabled(true);
        }
        mountedPlayer.transform.SetParent(null);
        mountedPlayer.transform.position = standPoint.position;
        mountedPlayer.transform.rotation = standPoint.rotation;

        if (controller != null)
        {
            controller.enabled = true;
        }

        mountedPlayer = null;
    }
}