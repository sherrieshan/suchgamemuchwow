using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	public AnimationClip die;
	public Animator anim;
	bool died;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (died && Input.anyKeyDown) {
			died = false;
			anim.SetBool ("Death", died);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			death();
		}
	}

	void death() {
		float animTime = die.length;
		StartCoroutine (deathRoutine (animTime));
	}
	
	IEnumerator deathRoutine(float time)
	{
		died = true;
		anim.SetBool ("Death", died);
		yield return new WaitForSeconds(time);
		
	}
}
