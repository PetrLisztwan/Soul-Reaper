using System;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public static event Action OnBossDead;

    private void OnDestroy()
    {
        OnBossDead?.Invoke();
    }
}
