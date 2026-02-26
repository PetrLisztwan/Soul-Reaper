using System;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public static event Action OnBossDead;

    private void OnDestroy()
    {
        OnBossDead?.Invoke();
        Debug.Log("Boss is dead");
    }
}
