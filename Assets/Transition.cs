using UnityEngine;

public class Transition : MonoBehaviour
{
    public static System.Action AnimationDisabled;
    [SerializeField] GameObject player;
    private SpriteRenderer TransitionSprite;
    Animator Anim;

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        TransitionSprite = GetComponent<SpriteRenderer>();
        Anim.Play("LeftUpTransition");
    }

    void OnEnable()
    {
        Transition.AnimationDisabled += ActivatePlayer;
    }

    void OnDisable()
    {
        Transition.AnimationDisabled -= ActivatePlayer;
    }

    public void DisableTransitionSprite()
    {
        TransitionSprite.enabled = false;
        AnimationDisabled?.Invoke();
    }

    void ActivatePlayer()
    {
        player.SetActive(true);
    }
}
