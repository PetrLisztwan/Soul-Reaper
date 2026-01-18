using UnityEngine;

public class HeartsUIChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] heartSprites;
    [SerializeField] private Health playerHealth;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (playerHealth.health <= 0)
        {
            spriteRenderer.sprite = heartSprites[0];
        }
        else if (playerHealth.health < 33)
        {
            spriteRenderer.sprite = heartSprites[1];
        }
        else if (playerHealth.health < 66)
        {
            spriteRenderer.sprite = heartSprites[2];
        }
        else
        {
            spriteRenderer.sprite = heartSprites[3]; 
        }
    }
}
