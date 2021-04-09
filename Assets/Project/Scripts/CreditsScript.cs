using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditsScript : MonoBehaviour
{
   public GameObject CreditsPanel;
   void Awake()
   {
   	hideCreditsPanel();
   	Debug.unityLogger.logEnabled = false;
   	
   	}

   	public void ShowCreditsPanel()
   	{
   		CreditsPanel.SetActive(true);
   	}
   	public void hideCreditsPanel()
   	{
   		CreditsPanel.SetActive(false);
   	}

   	public void ShowMenu()
   	{
   		SceneManager.LoadScene ("MainMenu");
   		
   	}
   }

