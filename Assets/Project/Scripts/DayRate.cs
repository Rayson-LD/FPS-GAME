using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DayRate : MonoBehaviour
{
    [Header("Cash")]
    public Text Cash;

    [Header("Rate")]
    public InputField Rate;

    [Header("Chendu")]
    public InputField Chendu;

    [Header("Hoove")]
    public InputField Hoove;

   public void Calculate()
    {
    float a6 = float.Parse(Rate.text);
        float b6 = float.Parse(Chendu.text);
        float c6 = float.Parse(Hoove.text);
        
        float d7 = (((a6*b6)/4)+((a6*c6)/3200));
        Cash.text = d7.ToString("F2");
    }
}
