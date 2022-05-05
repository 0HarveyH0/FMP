using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerManager : MonoBehaviour
{
	public Transform[] spawnLocations;	
	void OnPlayerJoined(PlayerInput playerInput)
	{
		Debug.Log("PlayerInput Joined" + playerInput.playerIndex);

		playerInput.gameObject.GetComponent<playerDetails>().playerID = playerInput.playerIndex + 1;

		playerInput.gameObject.GetComponent<playerDetails>().startPos = spawnLocations[playerInput.playerIndex].position;

	}

}
