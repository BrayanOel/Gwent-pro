using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GwentPro;

public class CardBack : MonoBehaviour
{         
    void start ()
	{
        
    }
	
	void Update ()
	{
        if(ThisCard.staticCardBack == true)
		{
            CardBack.SetActivate(true);
        }
		else
		{
            CardBack.SetActivate(false);
        }
    }
}
