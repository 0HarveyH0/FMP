using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
	private Rigidbody rb;
	public float force;
	public float moveSpeed;
	private PlayerInput playerInput;
	private FMP playerInputActions;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		playerInput = GetComponent<PlayerInput>();

		playerInputActions = new FMP();
		playerInputActions.RLGL.MoveForward.Enable();
		playerInputActions.RLGL.MoveForward.performed += MoveForward;
	}


	private void FixedUpdate()
	{
		//Vector2 inputVector = PlayerInputActions.RLGL
	}

	void Update()
	{
		Vector2 inputVector = playerInputActions.RLGL.MoveForward.ReadValue<Vector2>();
		rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed, ForceMode.Force);
	}


	public void MoveForward(InputAction.CallbackContext context)
	{
		Debug.Log(context);
		Vector2 inputVector = context.ReadValue<Vector2>();
		rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed, ForceMode.Force);
	}


	private void OnEnable()
	{

	}

	private void OnDisable()
	{

	}
}
