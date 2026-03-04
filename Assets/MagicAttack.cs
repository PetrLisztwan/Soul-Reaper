using System.Collections;
using TMPro;
using UnityEngine;

public class MagicAttack : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI AbilityText;

    private SpriteRenderer magicAttackSprite;
    private Collider2D attackCollider;

    public float cooldown;
    public bool abilityReady;
    public int damage = 100;

    Animator Anim;

    private void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        magicAttackSprite = GetComponent<SpriteRenderer>();
        attackCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        mouseWorldPos.z = 0;

        //transform.position = mouseWorldPos;

        //Debug.Log("X:" + mouseWorldPos.x);
        //Debug.Log("Y:" + mouseWorldPos.y);

        CastAbility(mouseWorldPos);
    }
    public void ActivateHitbox()
    {
        attackCollider.enabled = true;
    }
    public void DeactivateHitbox()
    {
        attackCollider.enabled = false;
    }

    public void DisableMagicSprite()
    {
        magicAttackSprite.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }
    private void CastAbility(Vector3 targetPos)
    {
        if (abilityReady == false)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            transform.position = targetPos; 
            magicAttackSprite.enabled = true;
            Debug.Log("RMB pressed down");
            Anim.SetTrigger("Active");
     
            StartCoroutine(AbilityCooldownRoutine(cooldown));
        }
        else
        {
            Anim.SetTrigger("Idle");
            //magicAttackSprite.enabled = false;
        }
    }

    IEnumerator AbilityCooldownRoutine(float cooldown)
    {
        abilityReady = false;
        float timer = cooldown;

        while (timer > 0)
        {
            AbilityText.text = timer.ToString("F1");
            timer -= Time.deltaTime;
            yield return null;
        }

        //yield return new WaitForSeconds(cooldown);
        AbilityText.text = "RMB";
        abilityReady = true;
    }
}


