using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public int damage = 3;

    private void Start()
    {
        if (ChangeDamage.limboDamageApplied)
        {
            damage = 10;
        }
    }

    private void Update()
    {
        Debug.Log(damage);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }
}