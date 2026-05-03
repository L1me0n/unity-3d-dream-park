using UnityEngine;

public class SwordInteractable : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] private GameObject player;
    [SerializeField] private Transform playerSword;

    private bool isTaken = false;

    public string GetPromptText()
    {
        if (isTaken)
        {
            return "";
        }

        return "Press E to take";
    }

    public void Interact(PlayerInteraction playerInteraction)
    {
        if (playerSword == null)
        {
            player = playerInteraction.gameObject;
            playerSword = player.transform.Find("SwordPivot");
        }
        playerSword.gameObject.SetActive(true);
        Destroy(gameObject);
        isTaken = true;
    }

}
