using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsUI : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
