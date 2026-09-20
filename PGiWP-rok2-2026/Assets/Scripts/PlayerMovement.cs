using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 3f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private float moveX;

    private int jumpCount = 0;
    public int maxJumps = 2;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Движение влево-вправо
        moveX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveX * movementSpeed, rb.linearVelocity.y);

        // Прыжок с ограничением
        if (Input.GetButtonDown("Jump") && jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpCount++; // Увеличиваем счетчик прыжков
        }
    } // <-- ВОТ ЭТУ СКОБКУ МЫ ВЕРНУЛИ! Теперь функция Update закрыта правильно.

    // Звук при приземлении на землю
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.name.Contains("Tilemap"))
        {
            jumpCount = 0; // Шарик на земле — прыжки снова доступны!

            AudioSource audio = GetComponent<AudioSource>();
            if (audio != null && !audio.isPlaying)
            {
                audio.Play();
            }
        }
    }
}