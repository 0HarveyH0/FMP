using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject cameraHandler;

    Animator cameraAnim;

	private void Awake()
	{
        cameraAnim = cameraHandler.GetComponent<Animator>();
	}



	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMinigame()
	{
        cameraAnim.SetTrigger("SelectMinigame");
	}


}
