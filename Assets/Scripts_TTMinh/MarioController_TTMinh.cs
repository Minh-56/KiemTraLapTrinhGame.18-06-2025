using UnityEngine;

public class MarioController_TTMinh : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float checkRadius = 0.2f;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMovement_TTMinh();
        HandleJump_TTMinh();
        UpdateAnimation_TTMinh();
    }

    void HandleMovement_TTMinh()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        if (moveInput != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveInput), 1f, 1f);
        }
    }

    void HandleJump_TTMinh()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        if (Input.GetButtonDown("Jump_TTMinh") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    void UpdateAnimation_TTMinh()
    {
        if (!isGrounded)
        {
            animator.Play("Jump-TTMinh-Animation");
        }
        else if (Mathf.Abs(moveInput) > 0.1f)
        {
            animator.Play("Run-TTMinh-Animation");
        }
        else
        {
            animator.Play("Idle-TTMinh-Animation");
        }
    }
}

