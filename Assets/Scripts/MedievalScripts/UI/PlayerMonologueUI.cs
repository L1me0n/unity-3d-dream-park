using TMPro;
using UnityEngine;

public class PlayerMonologueUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerMonologueText;

    private int counter = 0;

    private void Awake()
    {
        Hide();
    }

    public void Show(string message)
    {
        if (counter < 1)
        {
            playerMonologueText.text = message;
            playerMonologueText.gameObject.SetActive(true);
            counter++;
        }
        
    }

    public void Hide()
    {
        playerMonologueText.text = "";
        playerMonologueText.gameObject.SetActive(false);
    }
}
