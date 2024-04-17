using UnityEngine;
using UnityEngine.SceneManagment;

namespace GwentPro;

public class Scene1 
{         
    public class SceneChanger : MonoBahaivor
	{
	    public void ChangeScene(string sceneName)
		{
		    SceneManager.LoadScene(sceneName);
		}
	}
}
