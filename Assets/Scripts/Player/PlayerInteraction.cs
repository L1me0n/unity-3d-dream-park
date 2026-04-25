using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InteractionPromptUI interactionPromptUI;

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