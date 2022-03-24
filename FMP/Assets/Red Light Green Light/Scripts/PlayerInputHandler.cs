using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerConfiguration playerConfig;
    private Mover mover;

    [SerializeField]
    private SkinnedMeshRenderer playerMesh;

    private FMP controls;
    private void Awake()
    {

        mover = GetComponent<Mover>();
        controls = new FMP();
    }

    public void InitialzePlayer(PlayerConfiguration pc)
	{
        playerConfig = pc;
        playerMesh.material = pc.PlayerMaterial;
		playerConfig.Input.onActionTriggered += Input_onActionTriggered;
	}

	private void Input_onActionTriggered(CallbackContext obj)
	{
        if(obj.action.name == controls.RLGL.MoveForward.name)
		{
            OnMove(obj);
		}
	}

	public void OnMove(CallbackContext context)
    {
        if (mover != null)
            mover.SetInputVector(context.ReadValue<Vector2>());
    }

}