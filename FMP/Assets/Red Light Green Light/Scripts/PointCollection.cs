using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCollection : MonoBehaviour
{

    public float points;
    public TextMeshProUGUI Points;

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
            Points.text = points.ToString();
        }
        else if (other.CompareTag("deductable"))
        {
            points--;
        }

    }

}
