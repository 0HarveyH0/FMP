using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject cameraHandler;
    public GameObject mainMenu;
    public GameObject SelectMinigameMenu;

    Animator cameraAnim;

	private void Awake()
	{
        cameraAnim = cameraHandler.GetComponent<Animator>();
        mainMenu.SetActive(true);
        SelectMinigameMenu.SetActive(false);
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
        mainMenu.SetActive(false);
        cameraAnim.SetTrigger("SelectMinigame");
        SelectMinigameMenu.SetActive(true);
	}

    public void Back()
	{
        mainMenu.SetActive(true);
        cameraAnim.SetTrigger("Idle");
    }

    public void RLGL()
	{
        SceneManager.LoadScene("RedLightGreenLight");
	}

    public void CoinCollector()
	{
        SceneManager.LoadScene("SecondMinigame");

    }

}
