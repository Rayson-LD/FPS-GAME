using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qUITgAME : MonoBehaviour
{
    public GameObject quitgame;
    public void Awake()
    {
    	quitgame.SetActive(false);


    }

    public void Quit()
    {
    	quitgame.SetActive(true);
    }

    public void Noquit()
    {
    	quitgame.SetActive(false);
    }

    public void quit()
    {
    	Application.Quit();
    }
}
