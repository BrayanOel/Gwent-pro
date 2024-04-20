using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GwentPro;

public class CardBackPrefab : MonoBehaviour
{
	public GameObject Deck;
	public GameObject It;

	void start()
	{

	}

	void Update()
	{
		Deck = GameObject.Find("Deck Panel");
		It.transform.SetParents(Deck.transform);
		It.transform.localScale = Vector3.one;
		It.transform.position = new Vector3.one(transform.position.x, transform.position.y, -48);
		It.transform.eulerAngles = new Vector3(25, 0, 0);
	}
}
