using UnityEngine;
using System.Collections;

public class LeftWall : MonoBehaviour {

	public Health dogeHealth;

	// Use this for initialization
	void Start () 
	{
		dogeHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "coin")
		{
			dogeHealth.takeDamage(3);
			Destroy(other.gameObject);
		}
	}
}
