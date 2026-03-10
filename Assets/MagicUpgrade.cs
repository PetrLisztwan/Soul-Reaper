using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagicUpgrade : MonoBehaviour
{
    public static bool limboMagicApplied;
    [SerializeField] private GameObject UpgradeMagicPrompt;
    [SerializeField] private TextMeshProUGUI MagicApplied;
    private bool playerInRange = false;
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !limboMagicApplied)
        {
            if (SoulDrop.soulsCollected >= 5)
            {
                Debug.Log("E is being pressed");
                limboMagicApplied = true;
                MagicApplied.text = "Upgrade successfully bought!";
                SoulDrop.soulsCollected -= 5;
            }
            else
            {
                MagicApplied.text = "Unsuccessfull, not enough Souls!";
                limboMagicApplied = false;
            }

        }

        Debug.Log("Number of Souls" + SoulDrop.soulsCollected);

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        playerInRange = true;

        if (!limboMagicApplied)
            UpgradeMagicPrompt.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        playerInRange = false;
        UpgradeMagicPrompt.SetActive(false);
    }
}
