using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newRun : MonoBehaviour
{
    private Collider2D PromptCollider;
    [SerializeField] private GameObject newRunPrompt;
    Animator Anim;
    private bool playerInRange = false;
    private void Start()
    {
        PromptCollider = GetComponent<Collider2D>();
        newRunPrompt.SetActive(false);
        Anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E is being pressed");
            SceneManager.LoadScene("Caveman_Era");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        newRunPrompt.SetActive(true);
        playerInRange = true;

    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        playerInRange = false;
        newRunPrompt.SetActive(false);
    }
}
