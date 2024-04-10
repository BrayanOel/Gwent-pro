using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GwentPro;

public class MonsterCards
{
	public int Power { get; set; }
	public string Name { get; set; }
	public string Faction { get; set; }
	public TipeMonster Tipe{ get; set; }

	public void createCard(int power, string name, string faction , TipeMonster tipe)
	{
		Power = power;
		Name = name;
		Faction = faction;
		Tipe = tipe;
	}
	
	public bool isTipe(TipeMonster tipe)
	{
	    return Tipe == tipe;
	}
}

public enum TipeMonster
{
    Warrior,
	Archer,
	Support,
}

/*MonsterCards myCard = new MonsterCards(TipeMonster.Warrior);

if (mycard.isTipe(TipeMonster.Warrior))
{
    //codigo si myCard es guerrero
}*/