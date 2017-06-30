using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{



	void Start()
	{

	}

	void Update()
	{

	}


	public void FLipCard()
	{
		transform.Rotate(new Vector3(0, 180, 0));
	}
}
