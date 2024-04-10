using System;
using System.Linq;
using System.Collections.Generic;

namespace GwentPro;

public class StrengthUp
{         
    public string Name{get;set;}
	public string EfectDescript{get;set;}
	
	public void StrengthUpCard (string name, string efect)
	{
	    Name = name;
	    EfectDescript = efect;
	}
}
