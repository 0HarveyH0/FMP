using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject cameraHandler;
    public GameObject mainMenu;
    public GameObject SelectMinigameMenu;
    public GameObject LinksMenu;
    public GameObject SettingsMenu;

    Animator cameraAnim;

	private void Awake()
	{
        cameraAnim = cameraHandler.GetComponent<Animator>();
        mainMenu.SetActive(true);
        SelectMinigameMenu.SetActive(false);
        SettingsMenu.SetActive(false);
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
        cameraAnim.SetBool("Idle", false);
        mainMenu.SetActive(false);
        cameraAnim.SetTrigger("SelectMinigame");
        SelectMinigameMenu.SetActive(true);
	}

    public void Back()
	{
        SettingsMenu.SetActive(false);
        SelectMinigameMenu.SetActive(false);
        LinksMenu.SetActive(false);
        mainMenu.SetActive(true);
        cameraAnim.SetBool("Idle", true);
    }

    public void RLGL()
	{
        SceneManager.LoadScene("RedLightGreenLight");
	}

    public void CoinCollector()
	{
        SceneManager.LoadScene("SecondMinigame");

    }

    public void Settings()
    {
        cameraAnim.SetBool("Idle", false);
        mainMenu.SetActive(false);
        cameraAnim.SetTrigger("Idle");
        SettingsMenu.SetActive(true);
    }

    public void Links()
	{
        StartCoroutine(LinksCo());
    }

    public void quit()
	{
        Application.Quit();
	}

    IEnumerator LinksCo()
	{
        cameraAnim.SetBool("Idle", false);
        mainMenu.SetActive(false);
        cameraAnim.SetTrigger("Links");
        yield return new WaitForSecondsRealtime(3);
        LinksMenu.SetActive(true);
    }


}
