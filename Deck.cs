using System;
using System.Linq;
using System.Collections.Generic;

namespace GwentPro;

public class Deck 
{	
    private List<MonsterCards> cards;
	//private int limitMax;
	//private int limitMin;
	
	public Deck(int Max, int Min)
	{
	    cards = new List<MonsterCards>();
		//limitMax = 40;
		//limitMin = 25;
	}
}

public static class Extensiones
{		
	public static Random rng = new Random();
	
	public static void shuffle<T>(this IList<T> lista)
	{
	    int n = lista.Count;
		while (n > 1)
		{
		    n--;
			int k = rng.Next(n + 1);
			T valor = lista[k];
			lista[k] = lista[n];
		    lista[n] = valor;
		}
	}
	//List<UnitCards> Deck = new List<UnitCards>();
	//Deck.shuffle();
}
