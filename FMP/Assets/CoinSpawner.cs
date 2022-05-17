using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject coin;
    public int spawnCount;
    public bool CoinCollected = false;
    public bool coinSpawned = false;

    // Start is called before the first frame update
    void Start()
    {

    }
	public void Awake()
	{

    }
    // Update is called once per frame
    void Update()
    {
        if (coinSpawned)
        {
            if (CoinCollected)
            {
                coin.SetActive(false);
            }
            else
            {

            }
        }
		else
		{
            coin = Instantiate(coin, spawnLocation.position, spawnLocation.rotation);
            coin.SetActive(true);
            coinSpawned = true;
        }
    }
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
            CoinCollected = false;
		}
	}



}
