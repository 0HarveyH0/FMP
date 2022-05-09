using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Transform[] spawnLocation = new Transform[10];
    public GameObject[] coins = new GameObject[3];
    public int spawnCount;
    private int itemIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        itemIndex = Random.Range(0, coins.Length);
        SpawnCollectables();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnAllCollectables()
    {
        //iterates through the number of collectables in items array
        for (int i = 0; i < coins.Length; i++)
        {
            //spawns a unique collectable
            SpawnCollectables();
        }
    }

    public void SpawnCollectables()
    {
        // first pick what random collectable you want to spawn
        GameObject randomCollectable = coins[Random.Range(0, coins.Length)];
        // next iterate all the spawn points, and spawn that item on each of them
        foreach (Transform spawnPoint in spawnLocation)
        {
            Instantiate(randomCollectable, spawnPoint.position, spawnPoint.rotation);           
        }
    }

    public GameObject GetCollectable()
    {
        int index = Random.Range(0, coins.Length);
        return coins[index];
    }

    public Transform GetCollectableSpawnPoint()
    {
        //Selects one of the coins
        itemIndex = itemIndex % coins.Length;
        //returns the selected point
        return spawnLocation[itemIndex++];
    }

}
