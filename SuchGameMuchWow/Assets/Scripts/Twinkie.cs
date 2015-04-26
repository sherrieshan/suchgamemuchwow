using UnityEngine;
using System.Collections;

public class Twinkie : MonoBehaviour {

	public float timeInstantiated = 0;
	public DogeController doge;

	// Use this for initialization
	void Start () 
	{
		doge = GameObject.FindGameObjectWithTag("Player").GetComponent<DogeController>();
		GetComponent<Rigidbody2D>().velocity = new Vector2(-3f, 0f);
		timeInstantiated = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(timeInstantiated < doge.timeHitRightWall)
		{
			doge.GetComponent<Health>().takeDamage(3);
			Destroy(this.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.tag == "Player")
		{
			DogeController doge = other.gameObject.GetComponent<DogeController>();
			doge.setTwinkie(true);
			Destroy(this.gameObject);
		}
	}
}
