using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerConfigurationManager : MonoBehaviour
{
	private List<PlayerConfiguration> playerConfigs;

	[SerializeField]
	private int MaxPlayers = 4;

	public static PlayerConfigurationManager Instance { get; private set; }

	private void Awake()
	{
		if(Instance != null)
		{
			Debug.Log("Trying to create another instance");
		}
		else
		{
			Instance = this;
			DontDestroyOnLoad(Instance);
			playerConfigs = new List<PlayerConfiguration>();
		}
	}

	public List<PlayerConfiguration> GetPlayerConfigs()
	{
		return playerConfigs;
	}

	public void SetPlayerColour(int index, Material colour)
	{
		playerConfigs[index].PlayerMaterial = colour;
	}

	public void ReadyPlayer(int index)
	{
		playerConfigs[index].IsReady = true;
		if(playerConfigs.Count == MaxPlayers && playerConfigs.All(p => p.IsReady == true))
		{
			SceneManager.LoadScene("mazeminigame");
		}
	}

	public void HandlePlayerJoin(PlayerInput pi)
	{
		Debug.Log("Player Joined" + pi.playerIndex);
		
		if(!playerConfigs.Any(p => p.PlayerIndex == pi.playerIndex))
		{
			pi.transform.SetParent(transform);
			playerConfigs.Add(new PlayerConfiguration(pi));
		}
	}
}

public class PlayerConfiguration
{
	public PlayerConfiguration(PlayerInput pi)
	{
		PlayerIndex = pi.playerIndex;
		Input = pi;
	}
	public PlayerInput Input { get; set; }
	public int PlayerIndex { get; set; }
	public bool IsReady { get; set; }
	public Material PlayerMaterial { get; set; }
}
