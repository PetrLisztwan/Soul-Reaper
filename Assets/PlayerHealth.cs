using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : Health
{
    protected override void Die()
    {
        Time.timeScale = 0; 
        Debug.Log("Player has died!");
        SceneManager.LoadScene("Limbo");
    }
}
