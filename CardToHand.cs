using System;
using System.Linq;
using System.Collections.Generic;

namespace GwentPro;

public class CardToHand : MonoBehaviour
{      
	public GameObject Hand;
	public GameObject It;

	void start()
	{

	}

	void Update()
	{
		Hand = GameObject.Find("Hand");
		It.transform.SetParents(Hand.transform);
		It.transform.localScale = Vector3.one;
		It.transform.position = new Vector3.one(transform.position.x, transform.position.y, -48);
		It.transform.eulerAngles = new Vector3(25, 0, 0);
	}
}
