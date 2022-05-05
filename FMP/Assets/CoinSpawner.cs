using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject coinPrefab;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        index = Random.Range(0, spawnLocations.Length);
        
        Instantiate(coinPrefab, spawnLocations[], Quaternion.identity);
    }
}
