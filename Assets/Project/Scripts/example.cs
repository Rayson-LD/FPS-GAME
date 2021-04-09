using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class example : MonoBehaviour
{
  	[Header("InputField")]
   	 public InputField Num1;
   	 public InputField Num2;

   public Text Result;

    public void Calculate()
    {
    	
    	int a = Convert.ToInt32(Num1.text);
    	int b = Convert.ToInt32(Num2.text);

    	int c = a+b;
    	Result.text = c.ToString();
    }
}
