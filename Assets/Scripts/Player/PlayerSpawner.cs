using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject player; // reference to the player prefab

    private GameObject playerCheck; // to keep track of the instantiated player

    private void Awake()
    {
        playerCheck = GameObject.FindWithTag("Player"); // find the player in the scene
        if (playerCheck == null)
        {
            Instantiate(player, player.transform.position, player.transform.rotation); // create the player instance if it doesn't exist (e.g. first time loading the hub)
        }
    }
}
