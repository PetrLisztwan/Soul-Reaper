using UnityEngine;

public class RelicPickup : MonoBehaviour
{
    public static System.Action relicPickup;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            relicPickup?.Invoke();
            Destroy(gameObject);
        }
    }
}
