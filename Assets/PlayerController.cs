using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float movementSpeed = 3f;
    private float dodge = 6f;
    //private float dodgeDuration = 0.15f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(movementDirection * dodge, ForceMode2D.Impulse);
            Debug.Log("Spacebar pressed down");
        }

    }


    private void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * movementSpeed;
    }

}
  