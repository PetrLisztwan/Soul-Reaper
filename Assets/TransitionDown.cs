using UnityEngine;
using UnityEngine.SceneManagement;
public class TransitionDown : MonoBehaviour
{
    public static System.Action AnimationDisabled;
    [SerializeField] GameObject player;
    private SpriteRenderer TransitionDownSprite;
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

       if (movingLeft == true)
       {
           Anim.Play("LeftTransition");
           SceneManager.LoadScene("Limbo");
       }
       else
       {
           Anim.Play("RightTransition");
           SceneManager.LoadScene("Limbo");
       }
    }
}
