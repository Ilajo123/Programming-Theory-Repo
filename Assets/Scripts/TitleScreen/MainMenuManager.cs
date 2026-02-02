using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField input;
    [SerializeField] private PlayerDetails playerDetails;

    private void Start()
    {
        
    }
    public void StartGame()
    {
        if (input.text == "")
        {
            playerDetails.playerName = "Player";
        } else
        {
            playerDetails.playerName = "Test";
        }

        SceneManager.LoadScene("Main");
        
    }
}
