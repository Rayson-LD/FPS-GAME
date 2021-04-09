using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSound : MonoBehaviour
{
  public AudioSource buttonSound;

  public void OnClickGUI()
  {
  	buttonSound.Play();
  }

  public void OpenScene()
  {
  	SceneManager.LoadScene("J&J-1");
  }
}