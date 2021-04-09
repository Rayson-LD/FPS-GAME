using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
 
public class carManager : MonoBehaviour
{
     public Camera carCam;
    public CarUserControl userCtrl;
    private bool inVeh;
    private GameObject player;
    public CarAudio audio;

	void Start () {
        userCtrl.enabled = false;
        carCam.enabled = false;
        audio.enabled = false;
        inVeh = false;
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(inVeh == true)
            {
                vehicleControl(null);
            }
        }
	}

    public void vehicleControl(GameObject playerObj)
    {
        if(inVeh == false)
        {
            player = playerObj;
            carCam.enabled = true;
            userCtrl.enabled = true;
            audio.enabled = true;
            player.SetActive(false);
            player.transform.parent = this.transform;

            StartCoroutine(Time(true));
        }
        else
        {
            player.SetActive(true);
            carCam.enabled = false;
            userCtrl.enabled = false;
             audio.enabled = false;
            player.transform.parent = null;
            player = null;

            StartCoroutine(Time(false));
        }
    }

    private IEnumerator Time(bool inVehicle)
    {
        yield return new WaitForSeconds(1);
        inVeh = inVehicle;
    }
}
