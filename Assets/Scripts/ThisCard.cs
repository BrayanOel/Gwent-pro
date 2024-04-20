using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace GwentPro;

public class ThisCard : MonoBehaviour
{         
  public List<Card> thisCard = new List<Card>();
	public int thisID;
	
	public int Power;
	public string Name;
	public string Faction;
	public TipeMonster Type;
	public string CardDescription;
	
	public Sprite ThisSprite;
	public Image thatImage;
	
	public bool cardBack;
	public static bool staticCardBack;
	
	public GameObject Hand;
	
	public int numberOfCardsInDeck;
	
/*	public bool canBeSummon;
	public bool Summoned;
	public GameObject battleZone;
	
	public static int drawX;
	public int DrawXcards;*/
	
	void start ()
	{
    thisCard [0] = CardDataBase.cardList[thisID]
		numberOfCardsInDeck = PlayerDeck.deckSize;
		
		//drawX = 0;
    }
	
	void Update ()
	{
        Hand = GameObject.Find("Hand");
		if(this.transform.parent == Hand.transform.parent)
		{
            cardBack = false;
        }
			
        Power = thisCard[0].Power;
		Name = thisCard[0].Name;
		Faction = thisCard[0].Faction;
		Type = thisCard[0].Type;
		CardDescription = thisCard[0].CardDescription;
		
	//	DrawXcards = ThisCard[0].DrawXcards;
		
		ThisSprite = thisCard[0].thisImage;
		
		powerText.text = "" + Power;
		nameText.text = "" + Name;
		cardDescriptionText.text = " " + CardDescription;
		
		ThatImage.sprite = ThisSprite;
		
		staticCardBack = cardBack;
		
		if (this.tag == "Clone")
		{
            thisCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck];
			numberOfCardsInDeck -= 1;
			PlayerDeck.deckSize -= 1;
			cardBack = false;
			this.tag = "Untagged";
        }
		
		
    }
}
