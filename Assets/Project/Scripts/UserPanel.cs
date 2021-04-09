using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UserPanel : MonoBehaviour
{
	 [Header("Rates")]
    public InputField MonRate;
    public InputField TueRate;
    public InputField WedRate;
    public InputField ThursRate;
    public InputField FriRate;
    public InputField SatRate;
    public InputField SunRate;
   
    [Header("Chendu")]
    public InputField MonChendu;
    public InputField TueChendu;
    public InputField WedChendu;
    public InputField ThursChendu;
    public InputField FriChendu;
    public InputField SatChendu;
    public InputField SunChendu;

    [Header("Hove")]
    public InputField MonHove;
    public InputField TueHove;
    public InputField WedHove;
    public InputField ThursHove;
    public InputField FriHove;
    public InputField SatHove;
    public InputField SunHove;

    [Header("Cash")]
    public Text MonCash;
    public Text TueCash;
    public Text WedCash;
    public Text ThursCash;
    public Text FriCash;
    public Text SatCash;
    public Text SunCash;

    [Header("Total")]
    public Text Total;

    [Header("Panels")]
    public GameObject RatePanel;
    public GameObject ChenduPanel;
    public GameObject HoovePanel;
    public GameObject CashPanel;
void Start()
{
	ChenduPanel.SetActive(false);
	HoovePanel.SetActive(false);
	CashPanel.SetActive(false);
}
public void ClickRate()
{
	RatePanel.SetActive(false);
	ChenduPanel.SetActive(true);
}
public void ClickChendu()
{
	RatePanel.SetActive(false);
	ChenduPanel.SetActive(false);
	HoovePanel.SetActive(true);
}
public void ClickHoove()
{
	RatePanel.SetActive(false);
	ChenduPanel.SetActive(false);
	HoovePanel.SetActive(false);
	CashPanel.SetActive(true);
}
    public void Calculate()
    {
    	
    	float a = float.Parse(MonRate.text);
        float b = float.Parse(MonChendu.text);
        float c = float.Parse(MonHove.text);
        
        float d1 = (((a*b)/4)+((a*c)/3200));
        MonCash.text = d1.ToString("F2");

        float a1 = float.Parse(TueRate.text);
        float b1 = float.Parse(TueChendu.text);
        float c1 = float.Parse(TueHove.text);
        
        float d2 = (((a1*b1)/4)+((a1*c1)/3200));
        TueCash.text = d2.ToString("F2");

        float a2 = float.Parse(WedRate.text);
        float b2 = float.Parse(WedChendu.text);
        float c2 = float.Parse(WedHove.text);
        
        float d3 = (((a2*b2)/4)+((a2*c2)/3200));
        WedCash.text = d3.ToString("F2");

        float a3 = float.Parse(ThursRate.text);
        float b3 = float.Parse(ThursChendu.text);
        float c3 = float.Parse(ThursHove.text);
        
        float d4 = (((a3*b3)/4)+((a3*c3)/3200));
        ThursCash.text = d4.ToString("F2");

        float a4 = float.Parse(FriRate.text);
        float b4 = float.Parse(FriChendu.text);
        float c4 = float.Parse(FriHove.text);
        
        float d5 = (((a4*b4)/4)+((a4*c4)/3200));
        FriCash.text = d5.ToString("F2");

        float a5 = float.Parse(SatRate.text);
        float b5 = float.Parse(SatChendu.text);
        float c5 = float.Parse(SatHove.text);
        
        float d6 = (((a5*b5)/4)+((a5*c5)/3200));
        SatCash.text = d6.ToString("F2");

        float a6 = float.Parse(SunRate.text);
        float b6 = float.Parse(SunChendu.text);
        float c6 = float.Parse(SunHove.text);
        
        float d7 = (((a6*b6)/4)+((a6*c6)/3200));
        SunCash.text = d7.ToString("F2");

        float sum = d1+d2+d3+d4+d5+d6+d7;
        Total.text = sum.ToString("F2");
    
    }


}
