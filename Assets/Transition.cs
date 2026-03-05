using UnityEngine;

public class Transition : MonoBehaviour
{
    private SpriteRenderer TransitionSprite;
    Animator Anim;

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        TransitionSprite = GetComponent<SpriteRenderer>();
    }

    
}
