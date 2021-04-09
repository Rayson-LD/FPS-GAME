using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour
{
    [Header("Visuals")]
	public GameObject container;
	public float rotationSpeed = 180f;

	[Header("Gameplay")]
	public int parts = 1;

	void Update () {
		container.transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);
	}
}
