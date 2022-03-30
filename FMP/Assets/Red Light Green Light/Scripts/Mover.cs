using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 3f;
    public int position = 0;
    public float gravity = -9.81f;
    private Animator anim;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public GameObject positionManager;
    public playerPosition playerPos;
    private PlayerInput pi;
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
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        playerPos = positionManager.GetComponent<playerPosition>();
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
            anim.SetFloat("Speed", moveDirection.z);
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
        anim.SetTrigger("Die");
    }
    public virtual void Win()
    {
        //stop moving
        canMove = false;
        //cant die
        anim.SetTrigger("Win");
        //debug player index
        //Debug.Log(PlayerConfiguration.);

        //Position(playerIndex);
        //playerPos.playerPositionList.Add(playerIndex);
        //switch (playerIndex)
        //{
            //case 0:

        //}
    }


    private void OnTriggerEnter(Collider other)
    {     
        if (other.CompareTag("Finish"))
        {
            Win();
        }

    }

    /*
    public void Position(float playerIndex)
    {
        switch (position)
        {
            case 0:
                Debug.Log($"{playerPos.playerPositionList[0]} is first");
                position++;
                break;
            case 1:
                Debug.Log($"{playerIndex + 1} is second");
                position++;
                break;
            case 2:
                Debug.Log($"{playerIndex + 1} is third");
                position++;
                break;
            case 3:
                Debug.Log($"{playerIndex + 1} is fourth");
                position++;
                break;
        }
    }
    */
}