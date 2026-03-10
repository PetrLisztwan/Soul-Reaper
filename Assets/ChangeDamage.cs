using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeDamage : MonoBehaviour
{
    public static bool limboDamageApplied;
    [SerializeField] private GameObject UpgradeDamagePrompt;
    [SerializeField] private TextMeshProUGUI DamageApplied;
    private bool playerInRange = false;
   private void Update()
   {
    if (playerInRange && Input.GetKeyDown(KeyCode.E) && !limboDamageApplied)
    {
        if (SoulDrop.soulsCollected >= 5)
            {
                Debug.Log("E is being pressed");
                limboDamageApplied = true;
                DamageApplied.text = "Upgrade successfully bought!";
                SoulDrop.soulsCollected -= 5;
            }
            else
            {
                DamageApplied.text = "Unsuccessfull, not enough Souls!";
                limboDamageApplied = false;
            }
 
    }

        Debug.Log("Number of Souls" + SoulDrop.soulsCollected);

   }

private void OnTriggerEnter2D(Collider2D collider)
{
    playerInRange = true;
    
    if (!limboDamageApplied) 
        UpgradeDamagePrompt.SetActive(true);
}
    private void OnTriggerExit2D(Collider2D collider)
    {
        playerInRange = false;
        UpgradeDamagePrompt.SetActive(false);
    }
}
