using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {
	public AnimationClip canvas;
	public AnimationClip next;
	Animator anim;
	bool started = false;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void Update() {
		if (Input.anyKeyDown) {
			startAnimation();
		}
	}

	void startAnimation() {
		//Debug.Log ("Starting animation!");
		float animTime = next.length;
		StartCoroutine (startRoutine (animTime));

	}
	
	IEnumerator startRoutine(float time)
	{
		started = true;
		anim.SetBool ("Start", started);
		yield return new WaitForSeconds(time);
		started = false;
		anim.SetBool ("Start", started);
		Load(1);
		
	}

	void Load(int level)
	{
		Debug.Log ("Is loading scene");
		Application.LoadLevel(level);
	}
}
