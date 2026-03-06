using UnityEngine;
using UnityEngine.SceneManagement;

public class EraChanger : MonoBehaviour
{
    public string sceneName;
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
        SceneManager.LoadScene(sceneName);
    }
}
