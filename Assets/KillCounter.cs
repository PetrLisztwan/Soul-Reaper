using UnityEngine;
using TMPro;

public class Boss : MonoBehaviour
{
    private int enemiesKilled;
    public static bool goalReached = false;
    [SerializeField] private TextMeshProUGUI counterText;
    [SerializeField] private EnemySpawner spawner;

    void OnEnable()
    {
        EnemyHealth.OnEnemyKilled += Addkills;
    }

    void OnDisable()
    {
        EnemyHealth.OnEnemyKilled -= Addkills;
    }

    void Addkills()
    {
        enemiesKilled++;
        counterText.text = enemiesKilled.ToString() + "/" + spawner.EnemyMaxSpawnCount;
    }

    void Update()
    {
        if (enemiesKilled >= spawner.EnemyMaxSpawnCount)
        {
            goalReached = true;
            enemiesKilled = 0;
        }
    }
}



