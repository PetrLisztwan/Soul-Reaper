using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float movementSpeed = 3f;
    private float dodge = 6f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * movementSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = movementDirection * dodge;
            Debug.Log("SpaceBar pressed down");
        }
        else
        {
            rb.linearVelocity = movementDirection * movementSpeed; 
        }


    }

}
  