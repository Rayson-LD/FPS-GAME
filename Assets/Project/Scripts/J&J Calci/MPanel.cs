using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPanel : MonoBehaviour
{

	[Header("Panel")]
   
    public GameObject panel1;
    public GameObject panel0;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject Sheet;

 
      void Awake()
    {
    	
    	panel1.SetActive(false);
    	panel2.SetActive(false);
    	panel3.SetActive(false);
    	panel4.SetActive(false);
    	panel5.SetActive(false);
    	panel6.SetActive(false);
    	Sheet.SetActive(false);

    }

    public void ShowPanel()
    {

    	panel0.SetActive(false);
    	panel1.SetActive(true);
    	

    
    	
    }

}
