using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Analytics.IAnalytic;
public class EnemyHealth : Health 
{
    public static System.Action OnEnemyKilled;
    public static System.Action OnBossKilled;

    [SerializeField] private EnemyData data;

    private void Start()
    {
        SetHealth(data.hp, data.hp);
    }

    protected override void Die()
    {
        OnEnemyKilled?.Invoke(); // Notify other scripts an enemy died
        Debug.Log("Event Fired: Enemy has died!");
        
        Destroy(gameObject);
    }

}
