using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
	private Rigidbody rb;
	public float force;
	public float moveSpeed;
	public bool canMove = true;
	Animator anim;
	private PlayerInput playerInput;
	private FMP playerInputActions;

	[SerializeField]
	private int playerIndex = 0; 

	public bool IsMoving()
    {
		anim.SetBool("Moving", true);
		return rb.velocity.magnitude > 0.1f;
    }

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		playerInput = GetComponent<PlayerInput>();
		anim = gameObject.GetComponent<Animator>();

		playerInputActions = new FMP();
		playerInputActions.RLGL.MoveForward.Enable();
		playerInputActions.RLGL.MoveForward.performed += MoveForward;
		playerInputActions.RLGL.ChangeScene.Enable();
		playerInputActions.RLGL.ChangeScene.performed += ChangeScene;
	}
	void Update()
	{
		if(canMove == true)
		{ 
			Vector2 inputVector = playerInputActions.RLGL.MoveForward.ReadValue<Vector2>();
			rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed, ForceMode.Force);
		}
		else
		{
			rb.velocity = Vector3.zero;
		}
	}

	public int GetPlayerIndex()
	{
		return playerIndex;
	}

	public void MoveForward(InputAction.CallbackContext context)
	{
		Debug.Log(context);
		Vector2 inputVector = context.ReadValue<Vector2>();
		rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed, ForceMode.Force);
	}

	private void ChangeScene(InputAction.CallbackContext context)
	{
		Debug.Log(context);
		SceneManager.LoadScene("MainMenu");
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

	private void OnEnable()
	{

	}

	private void OnDisable()
	{

	}
}
