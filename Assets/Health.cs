using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] public int health = 100;


    private int MAX_HEALTH = 100;

    public static Action OnPlayerDeath;
    public static Action OnEnemyDeath;
    //private int enemiesKilled = 0;


    public void SetHealth(int currentHealth, int maxHealth)
    {
        MAX_HEALTH = maxHealth;
        health = Mathf.Clamp(currentHealth, 0, MAX_HEALTH);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Damage(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException("Cannot have negative Damage");

        health -= amount;
        StartCoroutine(VisualIndicator(Color.red));

        if (health <= 0)

            Die();
    }
    private void Die()
    {
        Destroy(gameObject);
        if (this.CompareTag("Player"))
        {
            Time.timeScale = 0;

        }
        /*else if (this.CompareTag())
        {
            Debug.Log("I have killed an enemy");
            enemiesKilled++;

        }*/
    }

}