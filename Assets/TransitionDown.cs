using UnityEngine;
using UnityEngine.SceneManagement;
public class TransitionDown : MonoBehaviour
{
    public static System.Action AnimationDisabled;
    [SerializeField] GameObject player;
    Animator Anim;
    private PlayerMovement movingLeft;
    private PlayerMovement movingRight;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += transition;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= transition;
    }



    private void transition()
    {
       player.SetActive(false);
       Debug.Log("transition Active");
       Anim.SetTrigger("movingLeft");

        /*if (movingLeft == true)
       {
           Anim.SetTrigger("movingLeft");
           SceneManager.LoadScene("Limbo");
           Debug.Log("movingLeft");
       }
        if (movingRight == true)
        {
            Anim.SetTrigger("movingRight");
            SceneManager.LoadScene("Limbo");
            Debug.Log("movingLeft");
        }*/
    }
}
