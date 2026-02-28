using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Analytics.IAnalytic;
public class EnemyHealth : Health 
{
    public static System.Action OnEnemyKilled;
    public static System.Action OnBossKilled;

    [SerializeField] private EnemyData data;
    private EnemySpawner soulFragment;

    private void Start()
    {
        SetHealth(data.hp, data.hp);
    }

    protected override void Die()
    {
        OnEnemyKilled?.Invoke(); // Notify other scripts an enemy died
        Debug.Log("Event Fired: Enemy has died!");

        //Vector3 offset = new Vector3(Random.Range(-0.5f, 0.5f), 0.5f, 0);
        //Instantiate(soulFragment, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }

}
