using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour {

	public GameObject cardMesh;
	public Texture backside;
	public List<Texture> frontsides;

	List<GameObject> cards = new List<GameObject>();
	

	void Start () {

		InitializeCardMeshes();
		PutPicture();
	}
	
	void Update () {
		
	}


	void InitializeCardMeshes()
	{
		for (int i = 0; i < 5; i++)
		{
			GameObject tmp = Instantiate(cardMesh, new Vector3((i * 1.5f)-3f, 1, 5), Quaternion.identity);
			tmp.transform.Rotate(new Vector3(0, 180, 0));
			cards.Add(tmp);
		}
	}


	void PutPicture()
	{
		for (int i = 0; i < cards.Count; i++)
		{
			cards[i].transform.GetChild(0).GetComponent<MeshRenderer>().material.mainTexture = frontsides[i];
		}
	}
}
