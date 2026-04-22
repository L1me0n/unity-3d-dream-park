using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform playerSpawn; // where the player will spawn in the hub
    [SerializeField] private GameObject player; // reference to the player prefab
    [SerializeField] private CharacterController characterController; // reference to the player's CharacterController for teleporting

    private int counter = 0; // to track how many players we can instantiate, should only be 1

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // listen for scene changes to reposition player
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // stop listening when disabled
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // keep spawn manager across scenes
        if (counter < 1)
        {
            Instantiate(player, playerSpawn.position, playerSpawn.rotation); // create the player instance at the start
            counter++;
        }
    }

    private void Start()
    {
        MovePlayerToSpawn(); // position player at spawn point when hub loads
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "CentralHub")
        {
            player.SetActive(false); 
        }
        MovePlayerToSpawn(); // reposition player at spawn point whenever a new scene loads
    }

    private void MovePlayerToSpawn()
    {
        playerSpawn = GameObject.Find("PlayerSpawn").transform; // find the spawn point in the hub scene
        player = GameObject.FindWithTag("Player"); // find the player in the scene
        characterController = player.GetComponent<CharacterController>();
        if (player != null && playerSpawn != null)
        {
            if (characterController != null)
            {
                characterController.enabled = false; // disable controller to avoid physics issues when teleporting
                player.transform.position = playerSpawn.position;
                player.transform.rotation = playerSpawn.rotation;
                characterController.enabled = true; // re-enable controller after moving
            }
            else
            {
                Debug.LogWarning("Player does not have a CharacterController component!");
                player.transform.position = playerSpawn.position;
                player.transform.rotation = playerSpawn.rotation;
            }
            
        }
    }
}
