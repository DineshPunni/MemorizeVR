using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {

	CubeController cubeController;

	void Start()
	{
		cubeController = FindObjectOfType<CubeController>();
	}

	public void RestartGame()
	{
		cubeController.TeleportCube();
		cubeController.gameObject.SetActive(true);
	}
}
