using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GwentPro;

public class PlayerDeck : MonoBehaviour
{
	private List<MonsterCards> deck = new List<MonsterCards>();
	private List<MonsterCards> container = new List<MonsterCards>();

	public int x;
	public int deckSize;
	
	public GameObjet cardInDeck1;
	public GameObjet cardInDeck2;
	public GameObjet cardInDeck3;
	public GameObjet cardInDeck4;
	
	public GameObject CardBack;
	public GameObject Deck;
	
	public GameObject[] Clones;

	void start()
	{
		x = 0;
		deckSize = 40;
		for (int i = 0; i < deckSize; i++)
		{
			x = Random.Range(1 - 5);
			deck[i] = CardDataBase.cardList[x];
		}
		
		StartCoroutine(StartGame());
	}
	
	void Update ()
	{
        if(deckSize < 30)
		{
            cardInDeck1.SetActivate(false);
        }
		if(deckSize < 20)
		{
            cardInDeck2.SetActivate(false);
        }
		if(deckSize < 2)
		{
            cardInDeck3.SetActivate(false);
        }
		if(deckSize < 1)
		{
            cardInDeck4.SetActivate(false);
        }
    }
	
	IEnumerator Example()
	{
        yield return new WaitForSeconds(1);
		Clones = GameObject.FindGameObjectWithTag("Clone");
		
		foreach (GameObject Clone in Clones)
		{
            Destroy(Clone);
        }
    }
	
	IEnumerator Example()
	{
        for(int i = 0; i <=4;i++)
		{
            yield return new WaitForSeconds(1);
			Instantiate(CardToHand , transform.position, transform.rotation);
        }
    }

	public void Shuffle()
	{
        for (int i = 0; i < deckSize; i++)
		{
            container[0] = deck[i];
			int randomIndex = Random.Range(i,deckSize);
			deck[i] = deck[randomIndex];
			deck[randomIndex] = container[0];
        }
		
    } 
//	public void summon(){}
}
