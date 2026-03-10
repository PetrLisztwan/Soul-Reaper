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
        if (RelicDrop.RelicsCollected >= 5)
            {
                Debug.Log("E is being pressed");
                limboDamageApplied = true;
                DamageApplied.text = "Upgrade successfully bought!";
                RelicDrop.RelicsCollected -= 5;
            }
            else
            {
                DamageApplied.text = "Unsuccessfull, not enough !";
                limboDamageApplied = false;
            }
 
    }

        Debug.Log("Number of Relics" + RelicDrop.RelicsCollected);

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
