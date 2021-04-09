using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPage : MonoBehaviour
{
   public void OnAdmin()
   {
   	SceneManager.LoadScene("J&J-1");
   	
   }
 
 	public void OnUser()
   {
   	SceneManager.LoadScene("J&J-2");
   	
   }
   public void OnDaily()
   {
   	SceneManager.LoadScene("J&J-3");
   	
   }
}
