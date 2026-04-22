using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform playerSpawn; // where the player will spawn in the hub
    [SerializeField] private GameObject player; // reference to the player prefab

    private void Awake()
    {
        playerSpawn = GameObject.Find("PlayerSpawn").transform; // find the spawn point in the hub scene
        player = GameObject.FindWithTag("Player"); // find the player in the scene
    }
}
