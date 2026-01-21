using NUnit.Framework;
using UnityEngine;
public class EnemyHealth : Health 
{
    public static System.Action OnEnemyKilled;
    public static System.Action OnBossKilled;

    protected override void Die()
    {
        OnEnemyKilled?.Invoke(); // Notify other scripts an enemy died
        Debug.Log("Event Fired: Enemy has died!");

        Destroy(gameObject);
    }

}
