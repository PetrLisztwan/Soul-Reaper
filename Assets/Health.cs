using UnityEngine;
using System.Collections;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected int health; 
    [SerializeField] protected int maxHealth;

    public virtual void Damage(int amount)
    {
        health -= amount;
        StartCoroutine(VisualIndicator(Color.red));
        if (health <= 0) Die();
    }

    public void Update()
    {
        Debug.Log(gameObject.name + " Health: " + health, gameObject);
    }

    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int currentHealth, int maxHP)
    {
        maxHealth = maxHP;
        health = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    protected abstract void Die();

}   