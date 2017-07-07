using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	void Start () {

		Invoke("SelfDestruct", 3);
	}
	
	public void SelfDestruct()
	{
		Destroy(gameObject);
	}
	
}
