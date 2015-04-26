using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	
	public float speed = -3f;
	public float timeInstantiated = 0;
	public DogeController doge;
	
	// Use this for initialization
	void Start () 
	{
		doge = GameObject.FindGameObjectWithTag("Player").GetComponent<DogeController>();
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
		timeInstantiated = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(timeInstantiated < doge.timeHitRightWall)
		{
			Destroy(this.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			
			Destroy (this.gameObject);	
		}
	}
}
