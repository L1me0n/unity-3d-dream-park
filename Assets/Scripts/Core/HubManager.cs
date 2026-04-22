using UnityEngine;
using UnityEngine.SceneManagement;

public class HubManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject medievalLock;
    [SerializeField] private GameObject wildWestLock;
    [SerializeField] private GameObject dinosaurLock;
    [SerializeField] private GameObject piratesLock;
    [SerializeField] private GameObject olympusLock;

    private bool isMedievalLocked = true;
    private bool isWildWestLocked = true;
    private bool isDinosaurLocked = true;
    private bool isPiratesLocked = true;
    private bool isOlympusLocked = true;

    public void DoorEntered(string doorName)
    {
        switch (doorName)
        {
            case "MedievalDoor":
                SceneManager.LoadScene("MedievalPark");
                break;
            case "WildWestDoor":
                SceneManager.LoadScene("WildWestPark");
                break;
            case "DinosaurusDoor":
                SceneManager.LoadScene("DinosaursPark");
                break;
            case "PiratesDoor":
                SceneManager.LoadScene("PiratesPark");
                break;
            case "OlympusDoor":
                SceneManager.LoadScene("OlympusPark");
                break;
            case "ExitDoor":
                if (isMedievalLocked || isWildWestLocked || isDinosaurLocked || isPiratesLocked || isOlympusLocked)
                {
                    Debug.Log("You must unlock all parks before exiting!");
                    return;
                }
                Application.Quit();
                break;
            case "HubDoor":
                SceneManager.LoadScene("CentralHub");
                break;
        }
    }

    private void Update()
    {
        if (!isMedievalLocked)
            medievalLock.SetActive(false);
        if (!isWildWestLocked)
            wildWestLock.SetActive(false);
        if (!isDinosaurLocked)
            dinosaurLock.SetActive(false);
        if (!isPiratesLocked)
            piratesLock.SetActive(false);
        if (!isOlympusLocked)
            olympusLock.SetActive(false);
    }
}
