using UnityEngine;

public class HeartsUIChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] heartSprites;
    [SerializeField] private PlayerHealth playerHealth; 
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (playerHealth == null) return;

        // Call the method we just added to the Health script
        int currentHP = playerHealth.GetHealth();

        if (currentHP <= 0)
            spriteRenderer.sprite = heartSprites[0];
        else if (currentHP < 33)
            spriteRenderer.sprite = heartSprites[1];
        else if (currentHP < 66)
            spriteRenderer.sprite = heartSprites[2];
        else
            spriteRenderer.sprite = heartSprites[3];
    }
}
