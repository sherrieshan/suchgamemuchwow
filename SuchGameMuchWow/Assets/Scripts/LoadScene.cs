using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	void Update() {
		if (Input.GetKey (KeyCode.Return))
			Load (1);
		else if (Input.GetKey(KeyCode.Escape))
			QuitGame ();
	}

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
