using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PanelF : MonoBehaviour
{
    [Header("Panel")]
    public GameObject panel6;
    public GameObject panel5;
    public GameObject Sheet;

    [Header("InputField")]
    
    public InputField Date;
    public InputField MonRate;
    public InputField TueRate;
    public InputField WedRate;
    public InputField ThursRate;
    public InputField FriRate;
    public InputField SatRate;
    public InputField SunRate;

     [Header("Text")]
    public Text DateT;
    public Text MonRateT;
    public Text TueRateT;
    public Text WedRateT;
    public Text ThursRateT;
    public Text FriRateT;
    public Text SatRateT;
    public Text SunRateT;

    void Awake()
    {
    	HidePanel();
    	
    }

    public void ShowPanel()
    {

    	panel6.SetActive(false);
    	Sheet.SetActive(true);
    	DateT.text = "Date :" + Date.text;
    	MonRateT.text = MonRate.text;
    	TueRateT.text =  TueRate.text;
    	WedRateT.text =  WedRate.text;
    	ThursRateT.text =  ThursRate.text;
    	FriRateT.text =  FriRate.text;
    	SatRateT.text =  SatRate.text;
    	SunRateT.text =  SunRate.text;

    
    	
    }
 public void HidePanel()
    {
    	panel5.SetActive(true);
    	panel6.SetActive(false);
    }
}

