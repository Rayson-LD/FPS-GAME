using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
      private bool inTrigger;
    private GameObject player;
    public GameObject PopPanel;
    public carManager carMan;
void Start()
{
	hidePopPanel();
	  
}
    void Update()
    {
        if(inTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                carMan.vehicleControl(player);
                inTrigger = false;
                hidePopPanel();
            }
        }
    }

	void OnTriggerEnter (Collider col) {
        inTrigger = true;
        player = col.gameObject;
        showPopPanel();
	}
    void OnTriggerExit()
    {
        inTrigger = false;
        player = null;
        hidePopPanel();
    }
    public void showPopPanel(){
		PopPanel.SetActive (true);
	}

	public void hidePopPanel(){
		PopPanel.SetActive (false);
	}

}
