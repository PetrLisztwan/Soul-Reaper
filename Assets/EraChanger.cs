using UnityEngine;
using UnityEngine.SceneManagement;

public class EraChanger : MonoBehaviour
{
    private void OnEnable()
    {
        BossScript.OnBossDead += HandleBossDeath;
    }

    private void OnDisable()
    {
        BossScript.OnBossDead -= HandleBossDeath;
    }

    void HandleBossDeath()
    {
        Debug.Log("Boss is dead, changing eras");
        SceneManager.LoadScene("Medieval_Era");
    }
}
