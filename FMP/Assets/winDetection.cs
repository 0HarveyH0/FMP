using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class winDetection : MonoBehaviour
{
    public bool someoneWon;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (someoneWon)
        {
            winText.SetActive(true);
            SceneManager.LoadScene("PlayerConfigurator");
        }
    }
}
