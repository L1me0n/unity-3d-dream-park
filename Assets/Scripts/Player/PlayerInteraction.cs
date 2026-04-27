using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InteractionPromptUI interactionPromptUI;
    [SerializeField] private PlayerMonologueUI playerMonologueUI;

    [Header("Monologue Settings")]
    [SerializeField] private string monologueMessage = 
    "The key is probably in the castle. I have to get there";

    private IInteractable currentInteractable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerMonologueUI == null)
        {
            playerMonologueUI = FindObjectOfType<PlayerMonologueUI>();
        }
        if (other.CompareTag("MonologueZone"))
        {
            playerMonologueUI.Show(monologueMessage);
        }

        IInteractable interactable = other.GetComponentInParent<IInteractable>();
        if (interactionPromptUI == null)
        {
            interactionPromptUI = FindObjectOfType<InteractionPromptUI>();
        }

        if (interactable != null)
        {
            currentInteractable = interactable;
            interactionPromptUI.Show(currentInteractable.GetPromptText());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (playerMonologueUI == null)
        {
            playerMonologueUI = FindObjectOfType<PlayerMonologueUI>();
        }
        if (other.CompareTag("MonologueZone"))
        {
            playerMonologueUI.Hide();
        }
        
        IInteractable interactable = other.GetComponentInParent<IInteractable>();
        if (interactionPromptUI == null)
        {
            interactionPromptUI = FindObjectOfType<InteractionPromptUI>();
        }

        if (interactable != null && interactable == currentInteractable)
        {
            currentInteractable = null;
            interactionPromptUI.Hide();
        }
    }

    public void ClearCurrentInteractable()
    {
        if (interactionPromptUI == null)
        {
            interactionPromptUI = FindObjectOfType<InteractionPromptUI>();
        }
        currentInteractable = null;
        interactionPromptUI.Hide();
    }
}