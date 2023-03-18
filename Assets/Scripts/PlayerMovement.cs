using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Rigidbody2D rigidBody;
    [SerializeField]
    private BoxCollider2D boxCollider2D;
    [SerializeField]
    private AudioSource jumpAudio;
    [SerializeField]
    private LayerMask jumpableGround;
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float jumpHeight;
    private float dirX;

    private enum MovementState { Idle, Running, Jumping, Falling }
    private MovementState movementState;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Moving();

        Jumping();

        UpdateAnimations();
    }

    private void Moving()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rigidBody.velocity = new Vector2(dirX * playerSpeed, rigidBody.velocity.y);
    }

    private void Jumping()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpAudio.Play();
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpHeight);
        }
    }

    private void UpdateAnimations()
    {
        if (dirX > 0f)
        {
            spriteRenderer.flipX = false;
            movementState = MovementState.Running;
        }
        else if (dirX < 0f)
        {
            spriteRenderer.flipX = true;
            movementState = MovementState.Running;
        }
        else
        {
            movementState = MovementState.Idle;
        }

        if(rigidBody.velocity.y > 0.1f)
        {
            movementState = MovementState.Jumping;
        } 
        else if(rigidBody.velocity.y < -0.1f)
        {
            movementState = MovementState.Falling;
        }

        animator.SetInteger("State", (int)movementState);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }
}
