using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ public float moveSpeed = 5.0f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     float movex = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2( movex * moveSpeed, 0f);
    }
}
