using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	public float x;
	public float y;
	public float z;
	public float speed;

	public GameObject GameOverPrefab;


	public void TeleportCube()
	{
		float newX = Random.Range(-x, x); 
		float newY = Random.Range(0, y);
		float newZ = Random.Range(-z, z);

		transform.position = new Vector3(newX, newY, newZ);
		transform.LookAt(Camera.main.transform);
	}


	void Update()
	{
		transform.Translate(Vector3.forward*Time.deltaTime * speed);
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == ("Player"))
			Debug.Log("killed you");

		SpawnGameOverCanvas();
		Destroy(gameObject);
	}

	void SpawnGameOverCanvas()
	{
		GameObject tmp = Instantiate(GameOverPrefab, transform.position, Quaternion.identity);
		tmp.transform.LookAt(Camera.main.transform);
		tmp.transform.Rotate(new Vector3(0, 180, 0));
		tmp.transform.Translate(Vector3.forward * 5);
	}
}
