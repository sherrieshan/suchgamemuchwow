using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {
	public Animator anim;
	public AnimationClip die;
	public Text healthText;
	string startingHealth;
	string currentHealth;
	public int health = 10;
	bool hit = false;
	bool died = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

		string start = health.ToString();
		startingHealth = start;
		healthText.text = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (hit) {
			if(health <= 0)
				Death();
			string start = health.ToString();
			startingHealth = start;
			healthText.text = startingHealth;
			hit = false;
		}
	}

	public void addScore(int score) {
		hit = true;
		health += score;
	}

	public void takeDamage(int damage) {
		hit = true;
		health -= damage;
	}

	void Death() {
		float animTime = die.length;
		StartCoroutine (deathRoutine (animTime));
	}
	
	IEnumerator deathRoutine(float time)
	{
		died = true;
		anim.SetBool ("Died", died);
		yield return new WaitForSeconds(time);
		Application.LoadLevel(2);
		//died = false;
		//anim.SetBool ("Death", died);
		
	}
}
