using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private float speed = 3f;
    [SerializeField] private Animator animator;

    private Rigidbody2D body;
    public static Vector2 axisMovement;
    public bool movingLeft;
    public bool movingRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        axisMovement.x = Input.GetAxisRaw("Horizontal");
        axisMovement.y = Input.GetAxisRaw("Vertical");

        if (axisMovement.x != 0) { 
            animator.SetBool("isRunning", true);
        }
        else if (axisMovement.y != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        CheckForFlipping();
    }

    private void FixedUpdate() 
    {
        Move();
    }

    private void Move()
    {
        body.linearVelocity = axisMovement.normalized * speed;
    }

    private void CheckForFlipping()
    {
        movingLeft = axisMovement.x < 0;
        movingRight = axisMovement.x > 0;

        if (movingLeft)
        {
            transform.localScale = new Vector3(1.5f, transform.localScale.y);
        }

        if (movingRight)
        {
            transform.localScale = new Vector3(-1.5f, transform.localScale.y);
        }

    }

}
