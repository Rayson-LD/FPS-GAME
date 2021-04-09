using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController4 : MonoBehaviour {

	[Header("Game")]
	public Player player;
	public GameObject enemyContainer;
	public GameObject PopupPanel;
	public GameObject CharacterController;

	[Header("UI")]
	public Text healthText;
	public Text ammoText;
	public Text enemyText;
	public Text infoText;
	public Text PartsText;


	private bool gameOver = false;
	private float resetTimer = 3f;
	

	void Start () {
		infoText.gameObject.SetActive (false);
		hidePopupPanel();
	}

	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + player.Health;
		ammoText.text = "Ammo: " + player.Ammo;
		PartsText.text = "Parts: " + player.Parts;
		int aliveEnemies = 0;
		
		foreach (Enemy enemy in enemyContainer.GetComponentsInChildren<Enemy>()) {
			if (enemy.Killed == false) {
				aliveEnemies++;
			}
		}
		
		enemyText.text = "Enemies: " + aliveEnemies;

		if (aliveEnemies == 0 && player.Parts==1) {
			
			gameOver = true;
			
			infoText.gameObject.SetActive (true);
			infoText.text = "MISSION COMPLETED!";
			SceneManager.LoadScene ("Level6");
		

		}

		if (player.Killed == true) {
			
			gameOver = true;
		
			infoText.gameObject.SetActive (true);
			infoText.text = "MISSION FAILED";
			SceneManager.LoadScene ("Level5");
		}

		if (gameOver == true) {
			resetTimer -= Time.deltaTime;
			if (resetTimer <= 0) {
				
			}
		}
		
		  
	
	
if(Input.GetKeyDown(KeyCode.Escape))
		  {
		  	showPopupPanel();
		  	Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        GetComponent<CharacterController> ().enabled = false;
		GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = false;
		  	
		  }

    	}
    	public void showPopupPanel(){
		PopupPanel.SetActive (true);
		
	}

	public void hidePopupPanel(){

		PopupPanel.SetActive (false);
		  	Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GetComponent<CharacterController> ().enabled = true;
		GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
	}
	public void ShowMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

}
