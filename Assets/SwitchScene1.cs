using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene1 : MonoBehaviour
{
    public void SignUp()
    {
        SceneManager.LoadScene("SignUp");
    }
}