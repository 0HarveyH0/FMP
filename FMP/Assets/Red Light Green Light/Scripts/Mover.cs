using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 3f;
    public int position = 0;
    public float gravity = -9.81f;
    private Animator anim;
    public Transform groundCheck;
    public int points;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public GameObject positionManager;
    public Transform respawn;
    public uint Id { get; }
    public TextMeshProUGUI coinCounter;
    public static ReadOnlyArray<PlayerInput> all { get; }
    public playerPosition playerPos;
	private FMP playerInputActions;
	private PlayerInput input;
    Vector3 velocity;

    private CharacterController controller;

    public bool canMove = true;
    public bool IsMoving()
    {
        return anim.GetFloat("Speed") > 0.1f;
    }

    private Vector3 moveDirection = Vector3.zero;
    private Vector2 inputVector = Vector2.zero;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        playerPos = positionManager.GetComponent<playerPosition>();

        playerInputActions = new FMP();
        playerInputActions.RLGL.MoveForward.Enable();
        playerInputActions.RLGL.MoveForward.performed += MoveForward;

    }



    public void SetInputVector(Vector2 direction)
    {
        inputVector = direction;
    }

    void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.RLGL.MoveForward.ReadValue<Vector2>();

        
        if (canMove == true)
        {
            
			if (isGrounded())
			{
                anim.SetBool("IsGrounded", true);
			}

            

            if(isGrounded() && velocity.y < 0)
			{
                velocity.y = -2f;
			}

            moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= MoveSpeed;

            controller.Move(moveDirection * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;
            anim.SetFloat("moveX", inputVector.x);
            anim.SetFloat("moveY", inputVector.y);
            if(inputVector.x == 0 && inputVector.y == 0)
			{
                anim.SetBool("isMoving", false);
			}
			else
			{
                anim.SetBool("isMoving", true);
			}

            controller.Move(velocity * Time.deltaTime);
            anim.SetFloat("Speed", moveDirection.x + moveDirection.z);

            //Debug.Log(Id);
        }
		else
		{
            controller.velocity.Set(0, 0, 0);
		}
        
    }

    public void MoveForward(InputAction.CallbackContext context)
	{
        Vector2 inputVector = playerInputActions.RLGL.MoveForward.ReadValue<Vector2>();
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

        int index = PlayerPrefs.GetInt("playerIndex");

        Debug.Log(index);
        PlayerPrefs.SetInt("playerIndex", index + 1);
    }


    private void OnTriggerEnter(Collider other)
    {      
        if (other.CompareTag("Finish"))
        {
            Win();        
        }
        else if(other.CompareTag("Fall"))
        {
            Debug.Log("Fall");
            controller.enabled = false;
            transform.position = new Vector3(0f,3f,-38f);
            controller.enabled = true;
            anim.SetBool("IsGrounded", false);
		}
		if (other.CompareTag("collectable"))
		{
            points++;
            coinCounter.SetText(points.ToString());
		}



    }

    public bool isGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, groundMask);
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