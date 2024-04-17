using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Sistem.Serializable]

namespace GwentPro;

public class MonsterCards : MonoBehaviour
{
	public int Power;
	public string Name;
	public string Faction;
	public TypeMonster Type;
	public string CardDescription;
	 
	public int DrawXcards;

	public Sprite ThisImage;

	public MonsterCards(int power, string name, string faction, TypeMonster type, string cardDescription, Sprite thisImag, int drawXcards)
	{
		Power = power;
		Name = name;
		Faction = faction;
		Type = type;
		CardDescription = cardDescription;
		
		DrawXcards = drawXcards;

		ThisImage = thisImage;
	}

	public bool isType(TypeMonster type)
	{
		return Type == type;
	}
}

public enum TypeMonster
{
	Warrior,
	Archer,
	Support,
}
