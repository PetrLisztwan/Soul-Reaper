using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGameButton()
    {
        SceneManager.LoadScene("GameLoop");
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }
}
