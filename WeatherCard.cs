using System;
using System.Linq;
using System.Collections.Generic;

namespace GwentPro;

public class WeaterCard 
{         
    public string Name{get;set;}
	public string EfectDesciption{get;set;}
	//public EfectCard Efect{get;set;}
	
	public void createWeatherCard (string name,string efectDescription)
	{
	    Name = name;
	    EfectDesciption = efectDescription;
	}
}
