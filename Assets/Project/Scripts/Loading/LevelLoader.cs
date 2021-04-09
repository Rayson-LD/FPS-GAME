using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
	public GameObject LoadingPanel;
	public GameObject loadingScreen;
	public Slider slider;
	public Text ProgressText;
	
    public void LoadLevel(int sceneBuildIndex)
    {
    	showLoadingLevel();
    	
    	StartCoroutine(LoadAsynchronously(sceneBuildIndex));

    }
    IEnumerator LoadAsynchronously (int sceneBuildIndex)
    {
    	AsyncOperation operation = SceneManager.LoadSceneAsync(sceneBuildIndex);
    	loadingScreen.SetActive(true);
    	while(!operation.isDone)
    	{
    		float progress = Mathf.Clamp01(operation.progress/ .9f);
    		Debug.Log(progress);
    		slider.value= progress;
    		ProgressText.text = progress*100f+"%";

    		yield return null;
    	}
    }
    public void showLoadingLevel()
    {
    	LoadingPanel.SetActive(true);
    }
   
}
