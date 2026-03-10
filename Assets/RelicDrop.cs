using TMPro;
using UnityEngine;

public class RelicDrop : MonoBehaviour
{
    public GameObject Relic;
    [SerializeField] private TextMeshProUGUI RelicText;
    public static int RelicsCollected = 0;


    void OnEnable()
    {
        EnemyHealth.OnEnemyKilledPosition += relicDrop;
        RelicPickup.relicPickup += Displayrelics;
    }
    void OnDisable()
    {
        EnemyHealth.OnEnemyKilledPosition -= relicDrop;
        RelicPickup.relicPickup -= Displayrelics;
    }
    private void relicDrop(Vector3 enemyPosition)
    {
        if (Random.value > 0.25f) return;
        Vector3 offset = new Vector3(Random.Range(-0.2f, 0.2f), 0.2f, 0);
        Instantiate(Relic, enemyPosition + offset, Quaternion.identity);
    }

    private void Displayrelics()
    {
        RelicsCollected++;
        Debug.Log(RelicsCollected);
        RelicText.text = RelicsCollected.ToString();
    }
}
