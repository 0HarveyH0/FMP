using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 3f;

    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    [SerializeField]
    private int playerIndex = 0;

    private CharacterController controller;

    public bool canMove = true;
    public bool IsMoving()
    {
        return controller.velocity.magnitude > 0.1f;
    }

    private Vector3 moveDirection = Vector3.zero;
    private Vector2 inputVector = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction;
    }

    void Update()
    {
        if (canMove == true)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if(isGrounded && velocity.y < 0)
			{
                velocity.y = -2f;
			}

            moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= MoveSpeed;

            controller.Move(moveDirection * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
		else
		{
            controller.velocity.Set(0, 0, 0);
		}
    }
    public virtual void Die()
    {
        //death animation
        canMove = false;
    }
    public virtual void Win()
    {
        //stop moving
        //cant die
    }
}