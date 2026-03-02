using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Analytics.IAnalytic;
public class EnemyHealth : Health 
{
    public static System.Action OnEnemyKilled;
    public static System.Action<Vector3> OnEnemyKilledPosition;
    public static System.Action OnBossKilled;

    [SerializeField] private EnemyData data;
    private GameObject soulFragment;

    private void Start()
    {
        SetHealth(data.hp, data.hp);
    }

    protected override void Die()
    {
        OnEnemyKilled?.Invoke(); // Notify other scripts an enemy died
        OnEnemyKilledPosition?.Invoke(this.transform.position);
        Debug.Log("Event Fired: Enemy has died!");

        Destroy(gameObject);
    }

}
