using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PointPickup : MonoBehaviour
{
	public AudioSource coinCollect;
	private void Awake()
	{
		coinCollect = GetComponent<AudioSource>();
	}


	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{

		}
	}


}
