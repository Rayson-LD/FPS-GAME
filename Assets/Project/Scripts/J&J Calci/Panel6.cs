using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Panel6 : MonoBehaviour
{
	 [Header("Panel")]
   
    
    public GameObject panel1;
    public GameObject Sheet;
    public GameObject QuitPanel;

   [Header("Screenshot")]

   [SerializeField]
   private int maxAllowedScreenshots=500;
   private int nextScreenshotIndex=1;

   
    void Awake()
    {
    	panel1.SetActive(false);
        QuitPanel.SetActive(false);
    	
    	
    }

    public void ShowPanel()
    {

    	panel1.SetActive(true);
    	Sheet.SetActive(false);
    	

    
    	
    }

    public void QuitSheet()
    {
        QuitPanel.SetActive(true);
    }

    public void ShowScene()
    {
        SceneManager.LoadScene("J&J Calci");
    }

    public void HideScene()
    {
        QuitPanel.SetActive(false);
    }
 

 public void Screenshot()
 {
    if(nextScreenshotIndex < maxAllowedScreenshots)
    {
        ScreenCapture.CaptureScreenshot("G:/PottyPics/Potty" +nextScreenshotIndex+".png");
        nextScreenshotIndex++;
    }
 }
   
   
}
