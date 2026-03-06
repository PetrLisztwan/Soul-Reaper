using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    public static System.Action OnPlayerDeath;
    protected override void Die()
    {
        Debug.Log("Player has died!");
        OnPlayerDeath?.Invoke();
    }
}
