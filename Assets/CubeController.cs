using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	public float x;
	public float y;
	public float z;


	public void TeleportCube()
	{
		float newX = Random.Range(-x, x);
		float newY = Random.Range(0, y);
		float newZ = Random.Range(-z, z);

		transform.position = new Vector3(newX, newY, newZ);
	}
}
