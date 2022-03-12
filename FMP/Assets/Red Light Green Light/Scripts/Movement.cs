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
	private PlayerInput playerInput;
	private FMP playerInputActions;

	[SerializeField]
	private int playerIndex = 0; 

	public bool IsMoving()
    {
		return rb.velocity.magnitude > 0.1f;
    }

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		playerInput = GetComponent<PlayerInput>();

		playerInputActions = new FMP();
		playerInputActions.RLGL.MoveForward.Enable();
		playerInputActions.RLGL.MoveForward.performed += MoveForward;
		playerInputActions.RLGL.ChangeScene.Enable();
		playerInputActions.RLGL.ChangeScene.performed += ChangeScene;
	}


	private void FixedUpdate()
	{

	}

	void Update()
	{
		Vector2 inputVector = playerInputActions.RLGL.MoveForward.ReadValue<Vector2>();
		rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * moveSpeed, ForceMode.Force);
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

	private void OnEnable()
	{

	}

	private void OnDisable()
	{

	}
}
