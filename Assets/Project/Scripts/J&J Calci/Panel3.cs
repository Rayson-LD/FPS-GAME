using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Panel3 : MonoBehaviour
{
	 [Header("Panel")]
    public GameObject panel2;
    public GameObject Panel4;
    public GameObject panel3;
   

     [Header("InputField")]
     public InputField Name;
    public InputField Date;
    public InputField MonRate;
    public InputField TueRate;
    public InputField WedRate;
    public InputField ThursRate;
    public InputField FriRate;
    public InputField SatRate;
    public InputField SunRate;

     [Header("InputField1")]
   
    public InputField MonRate1;
    public InputField TueRate1;
    public InputField WedRate1;
    public InputField ThursRate1;
    public InputField FriRate1;
    public InputField SatRate1;
    public InputField SunRate1;

     [Header("InputField2")]
   
    public InputField MonRate2;
    public InputField TueRate2;
    public InputField WedRate2;
    public InputField ThursRate2;
    public InputField FriRate2;
    public InputField SatRate2;
    public InputField SunRate2;

     [Header("Text")]
    public Text DateT;
    public Text MonRateT;
    public Text TueRateT;
    public Text WedRateT;
    public Text ThursRateT;
    public Text FriRateT;
    public Text SatRateT;
    public Text SunRateT;

     [Header("Cash")]
    public Text MonRateC;
    public  Text TueRateC;
    public Text WedRateC;
    public Text ThursRateC;
    public Text FriRateC;
    public Text SatRateC;
    public Text SunRateC;
    public Text Total;

    [Header("Sheet")]
    public Text FName;
    public Text FDateT;
    public Text FMonRateT;
    public Text FTueRateT;
    public Text FWedRateT;
    public Text FThursRateT;
    public Text FFriRateT;
    public Text FSatRateT;
    public Text FSunRateT;

    public Text FMonRateC;
    public  Text FTueRateC;
    public Text FWedRateC;
    public Text FThursRateC;
    public Text FFriRateC;
    public Text FSatRateC;
    public Text FSunRateC;
    public Text FTotal;

    public Text FMonRate1;
    public Text FTueRate1;
    public Text FWedRate1;
    public Text FThursRate1;
    public Text FFriRate1;
    public Text FSatRate1;
    public Text FSunRate1;

    public Text FMonRate2;
    public Text FTueRate2;
    public Text FWedRate2;
    public Text FThursRate2;
    public Text FFriRate2;
    public Text FSatRate2;
    public Text FSunRate2;

    void Awake()
    {
    	HidePanel();
    	
    }

    public void ShowPanel()
    {

    	panel3.SetActive(false);
    	Panel4.SetActive(true);
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
    	panel2.SetActive(true);
    	panel3.SetActive(false);
    }



    public void Calculate()
    {
    	
    	float a = float.Parse(MonRate2.text);
        float b = float.Parse(MonRateT.text);
        float c = float.Parse(MonRate1.text);
        
        float d = (((b*c)/4)+((b*a)/3200));
        MonRateC.text = d.ToString("F2");

        float a1 = float.Parse(TueRate2.text);
        float b1 = float.Parse(TueRateT.text);
        float c1 = float.Parse(TueRate1.text);
        
        float d1 = (((b1*c1)/4)+((b1*a1)/3200));
        TueRateC.text = d1.ToString("F2");

        float a2 = float.Parse(WedRate2.text);
        float b2 = float.Parse(WedRateT.text);
        float c2 = float.Parse(WedRate1.text);
        
        float d2 = (((b2*c2)/4)+((b2*a2)/3200));
        WedRateC.text = d2.ToString("F2");

        float a3 = float.Parse(ThursRate2.text);
        float b3 = float.Parse(ThursRateT.text);
        float c3 = float.Parse(ThursRate1.text);
        
        float d3 = (((b3*c3)/4)+((b3*a3)/3200));
        ThursRateC.text = d3.ToString("F2");

        float a4 = float.Parse(FriRate2.text);
        float b4 = float.Parse(FriRateT.text);
        float c4 = float.Parse(FriRate1.text);
        
        float d4 = (((b4*c4)/4)+((b4*a4)/3200));
        FriRateC.text = d4.ToString("F2");

        float a5 = float.Parse(SatRate2.text);
        float b5 = float.Parse(SatRateT.text);
        float c5 = float.Parse(SatRate1.text);
        
        float d5 = (((b5*c5)/4)+((b5*a5)/3200));
        SatRateC.text = d5.ToString("F2");

        float a6 = float.Parse(SunRate2.text);
        float b6 = float.Parse(SunRateT.text);
        float c6 = float.Parse(SunRate1.text);
        
        float d6 = (((b6*c6)/4)+((b6*a6)/3200));
        SunRateC.text = d6.ToString("F2");

        float mon = float.Parse(MonRateC.text);
        float tue = float.Parse(TueRateC.text);
        float wed = float.Parse(WedRateC.text);
        float thurs = float.Parse(ThursRateC.text);
        float fri = float.Parse(FriRateC.text);
        float sat = float.Parse(SatRateC.text);
        float sun = float.Parse(SunRateC.text);

        float sum = mon+tue+wed+thurs+fri+sat+sun;
        Total.text = "Total : " +sum.ToString("F2");
    
    }

    public void Reload()
    {

   	FName.text="Name : " +Name.text;
    FDateT.text =  DateT.text;	
    FMonRateT.text = MonRateT.text;
    FTueRateT.text = TueRateT.text;
    FWedRateT.text = WedRateT.text;
    FThursRateT.text = ThursRateT.text;
    FFriRateT.text = FriRateT.text;
    FSatRateT.text = SatRateT.text;
    FSunRateT.text = SunRateT.text;

    FMonRateC.text = MonRateC.text;
    FTueRateC.text = TueRateC.text;
    FWedRateC.text = WedRateC.text;
    FThursRateC.text = ThursRateC.text;
    FFriRateC.text = FriRateC.text;
    FSatRateC.text = SatRateC.text;
    FSunRateC.text = SunRateC.text;
    FTotal.text = Total.text;

    FMonRate1.text = MonRate1.text;
    FTueRate1.text = TueRate1.text;
    FWedRate1.text = WedRate1.text;
    FThursRate1.text = ThursRate1.text;
    FFriRate1.text = FriRate1.text;
    FSatRate1.text = SatRate1.text;
    FSunRate1.text = SunRate1.text;

    FMonRate2.text = MonRate2.text;
    FTueRate2.text = TueRate2.text;
    FWedRate2.text = WedRate2.text;
    FThursRate2.text = ThursRate2.text;
    FFriRate2.text = FriRate2.text;
    FSatRate2.text = SatRate2.text;
    FSunRate2.text = SunRate2.text;
    	
    } 
  
}
