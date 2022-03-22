using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		Mover character = other.GetComponent<Mover>();

		if(character != null)
		{
			character.Win();
			Debug.Log(other.name + " has won!");
		}
	}

}
