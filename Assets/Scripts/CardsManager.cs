using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour {

	public List<Sprite> cardImages;
	public GameObject cardMesh;

	// Use this for initialization
	void Start () {

		InitializeCardMeshes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void InitializeCardMeshes()
	{
		for (int i = 0; i < 5; i++)
		{
			Instantiate(cardMesh, new Vector3(i * 1.3f, 2, 2), Quaternion.identity);
		}
	}
}
