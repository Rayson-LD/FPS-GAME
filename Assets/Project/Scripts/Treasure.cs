using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public AudioSource Success;
	public GameObject RiddlePanel;
    void Awake()
    {
    	hideRiddlePanel();
    }

    
    	void OnTriggerEnter(Collider OtherCollider)
    	{
            Success.Play();
    		showRiddlePanel();
    	}
        void OnTriggerExit(Collider OtherCollider)
        {
            Success.Pause();
            hideRiddlePanel();
        }

    	public void showRiddlePanel()
    	{
    			RiddlePanel.SetActive(true);
    		}
    		public void hideRiddlePanel()
    	{
    			RiddlePanel.SetActive(false);
    		}
    }

