using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static Action OnRestart;

	public GameObject GameOverPrefab;
	GameObject enemy;


	void OnEnable()
	{
		EnemyControl.OnGameOver += GameOver;
	}

	void GameOver()
	{
		enemy.SetActive(false);
		SpawnGameOverCanvas();
	}

	void OnDisable()
	{
		EnemyControl.OnGameOver -= GameOver;
	}

	void Start()
	{
		enemy = FindObjectOfType<EnemyControl>().gameObject;
	}



	public void Restart()
	{
		if (OnRestart != null)
			OnRestart();

		GameOverPrefab.SetActive(false);
		//Instantiate(enemy, new Vector3(0, 0, 5), Quaternion.identity);
		enemy.SetActive(true);
		enemy.GetComponent<EnemyControl>().TeleportEnemy();
	}


	void SpawnGameOverCanvas()
	{
		//GameObject tmp = Instantiate(GameOverPrefab, transform.position, Quaternion.identity);
		GameOverPrefab.SetActive(true);
		GameOverPrefab.transform.LookAt(Camera.main.transform);
		GameOverPrefab.transform.Rotate(new Vector3(0, 180, 0));
		GameOverPrefab.transform.Translate(Vector3.forward * 5);
	}
}
