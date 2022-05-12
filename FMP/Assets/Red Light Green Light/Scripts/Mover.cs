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
    Vector3 velocity;
    float turnSmoothVelocity;
    public float turnSmoothTime = 0.1f;
    public Transform cam;

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


	public void Update()
	{

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


            float horizontal = inputVector.x;
            float vertical = inputVector.y;
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(moveDir.normalized * MoveSpeed * Time.deltaTime);
            }

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
		else if (other.CompareTag("collectable"))
		{
            int randInt = Random.Range(-5, 7);
            points = points + randInt;
            coinCounter.SetText(points.ToString());

            GameObject coin = other.gameObject;

            StartCoroutine(coinSpawn(coin));

        }
    }

    IEnumerator coinSpawn(GameObject gameObject)
	{       
        gameObject.SetActive(false);
        int randomInt = Random.Range(5, 15);
        yield return new WaitForSeconds(randomInt);
        gameObject.SetActive(true);
	}



    public bool isGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, groundMask);
    }
}