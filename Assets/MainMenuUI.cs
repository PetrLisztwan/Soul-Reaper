using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGameButton()
    {
        SceneManager.LoadScene("GameLoop");
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene("settings");
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }
}
