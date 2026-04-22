using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private HubManager hubManager; // reference to the HubManager to notify when a door is entered

    private void Awake()
    {
        if (hubManager == null)
        {
           hubManager = FindObjectOfType<HubManager>(); // try to find the HubManager in the scene if not assigned
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hubManager.DoorEntered(gameObject.name);
        }
    }
}
