using System.Collections;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    [Header("Door Settings")]
    [SerializeField] private float openAngle = 90f; // Angle to open the door
    [SerializeField] private float openDuration = 1f; // Time it takes to open the door
    [SerializeField] private bool opensOnce = true; // If true, the door can only be opened once

    // Internal state
    private bool isOpen = false;
    private bool isMoving = false;
    private Quaternion closedRotation; // Initial rotation of the door
    private Quaternion targetRotation; // Rotation when the door is fully open

    private void Awake()
    {
        closedRotation = transform.rotation;
        targetRotation = closedRotation * Quaternion.Euler(0f, openAngle, 0f);
    }

    public string GetPromptText()
    {
        if (isOpen)
        {
            return "";
        }

        return "Press E to open";
    }

    public void Interact(PlayerInteraction playerInteraction)
    {
        if (isMoving)
        {
            return;
        }

        if (opensOnce && isOpen)
        {
            return;
        }

        StartCoroutine(OpenDoor());
    }

    private IEnumerator OpenDoor()
    {
        isMoving = true;

        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = targetRotation;

        float elapsed = 0f;

        while (elapsed < openDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / openDuration;
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            yield return null;
        }

        transform.rotation = endRotation;
        isOpen = true;
        isMoving = false;
    }
}