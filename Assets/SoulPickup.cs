using TMPro;
using UnityEngine;

public class SoulPickup : MonoBehaviour
{
    public static System.Action soulPickup;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            soulPickup?.Invoke();
            Destroy(gameObject);
        }
    }
}
