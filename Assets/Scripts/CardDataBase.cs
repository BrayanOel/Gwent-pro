using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GwentPro;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
	
	void Awake ()
	{
        cardList.add (new Card (0, "none" , 0 , 0 , 0 ,"none" , Resources.Load <Sprite>("0"), 0,0));
		cardList.add (new Card (5, "Elifas" , "SpaceMarinesChaos" , 0 ,0 , 0 , "Elifas the heritor" , Resources.Load <Sprite>("1"), 0));
		cardList.add (new Card (3, "Cultist" , "SpaceMarinesChaos" , 2 ,0 , 0 , "The witcher of fire" , Resources.Load <Sprite>("2"), 1));
		cardList.add (new Card (6, "SpaceMarine" , "SpaceMarinesChaos" , 1 ,0 , 0 , "SpaceMarene" , Resources.Load <Sprite>("3"), 0));
    }
}
