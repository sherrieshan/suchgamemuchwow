using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	void Load(int level)
	{
		Debug.Log ("Is loading scene");
		Application.LoadLevel(level);
	}

	void QuitGame()
	{
		Debug.Log ("Is quitting game");
		Application.Quit();
	}

}
