using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCollection : MonoBehaviour
{
    private List<PlayerConfiguration> playerConfigs;
    public float points;
    public int index;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"collided with {other.gameObject.name}");

        if (other.CompareTag("collectable"))
        {
            points++;
            Debug.Log($"Player has {points}");
        }
        else if (other.CompareTag("deductable"))
        {
            points--;
        }

    }

}
