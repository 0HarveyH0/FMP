using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Update()
    {
		if (Input.GetKey("space"))
		{
            SceneManager.LoadScene("Main Menu");
		}
    }
}
