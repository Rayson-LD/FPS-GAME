using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public GameObject popupPanel;
	public GameObject LoadingPanel;
	public GameObject CreditsPanel;
	public GameObject OptionPanel;
	public GameObject MenuPanel;
	
    void Awake()
    {
        // To show cursor after First Person Controller
    
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        hidePopupPanel();
        hideLoadingLevel();
        hideCreditsPanel();
        hideOptionPanel();
        Debug.unityLogger.logEnabled = false;
       
           
    }

   

 public void end()
    {
    Debug.Log("quit the game");
  Application.Quit();
  
	
    }
    public void showPopupPanel(){
		popupPanel.SetActive (true);
	}

	public void hidePopupPanel(){
		popupPanel.SetActive (false);
	}
public void multiplayer()
{
	SceneManager.LoadScene("GameLobby");
}
	public void hideLoadingLevel()
    {
    	LoadingPanel.SetActive(false);
    }
    public void showCreditsPanel(){
		CreditsPanel.SetActive (true);
	}

	public void hideCreditsPanel(){
		CreditsPanel.SetActive (false);
	}
	public void showOptionPanel(){
		OptionPanel.SetActive (true);
	}

	public void hideOptionPanel(){
		OptionPanel.SetActive (false);
	}



}

