using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Sistem.Serializable]

namespace GwentPro;

public class Card : MonoBehaviour
{
	public int Power;
	public string Name;
	public Faction faction;
	public CardType Type;
	public Rank rank;
	public string CardDescription;
	 
	public int DrawXcards;

	public Sprite ThisImage;

	public Card(int power, string name, Faction c_faction, CardType type,Rank _rank, string cardDescription, Sprite thisImag, int drawXcards)
	{
		Power = power;
		Name = name;
		faction = c_faction;
		Type = type;
		rank = _rank;
		CardDescription = cardDescription;
		
		DrawXcards = drawXcards;

		ThisImage = thisImage;
	}
}

public enum CardType
{
	Unit,
	Weather,
	Upgrade,
	Lure,
	ClearWeather
}

public enum Faction
{
  SpaceMarineChaos,
  Orc,
  Neutral
}

public enum Rank
{
 Goldial,
 Gold,
 Silver
}

public enum Effect
{
 Upgrade,
 Weather,
 ClearWeather,
 Lure,
 DestroyCard,
 CardUp,
 CardDown,
 DrawCard,
 NoEffect
}