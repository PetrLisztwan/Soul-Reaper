using UnityEngine;
using UnityEngine.UI;

public class HeartsUIChanger : MonoBehaviour
{
    [SerializeField] private Sprite[] heartSprites;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image heartImage;

    void Update()
    {
        if (playerHealth == null || heartImage == null) return;

        int currentHP = playerHealth.GetHealth();

        if (currentHP <= 0)
            heartImage.sprite = heartSprites[0];
        else if (currentHP < 33)
            heartImage.sprite = heartSprites[1];
        else if (currentHP < 66)
            heartImage.sprite = heartSprites[2];
        else
            heartImage.sprite = heartSprites[3];
    }
}