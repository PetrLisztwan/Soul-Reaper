using TMPro;
using UnityEngine;

public class SoulDrop : MonoBehaviour
{
    public GameObject soulFragment;
    public GameObject soul;
    [SerializeField] private TextMeshProUGUI SoulText;
    public static int soulsCollected = 0;


    void OnEnable()
    {
        EnemyHealth.OnEnemyKilledPosition += soulDrop;
        SoulPickup.soulPickup += DisplaySoul;
    }
    void OnDisable()
    {
        EnemyHealth.OnEnemyKilledPosition -= soulDrop;
        SoulPickup.soulPickup -= DisplaySoul;
    }
    private void soulDrop(Vector3 enemyPosition)
    {
        Vector3 offset = new Vector3(Random.Range(-0.5f, 0.5f), 0.5f, 0);
        Instantiate(soulFragment, enemyPosition + offset, Quaternion.identity);
    }

    private void DisplaySoul()
    {
        soulsCollected++;
        Debug.Log(soulsCollected);
        SoulText.text = soulsCollected.ToString();  
    }
}
