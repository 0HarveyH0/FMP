using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PointManager : MonoBehaviour
{

	[SerializeField]
	public float playerIndex;

	public int position = 0;

	public float winnerIndex;

	public Mover player;

	void Start()
	{
		player = FindObjectOfType<Mover>();
	}

	private void Update()
	{
			
	}

	public void Position(float playerIndex)
	{
		switch (position)
		{
			case 0:
				Debug.Log($"{playerIndex} is first");
				position++;
				break;
			case 1:
				Debug.Log($"{playerIndex} is second");
				position++;
				break;
		}
	}
}
