using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {
	
	public Vector2 originalPosition;
	public DogeController doge;
	
	// Use this for initialization
	void Start () 
	{
		originalPosition = transform.position;
		GetComponent<Rigidbody2D>().velocity = new Vector2(1,0);
		doge = GameObject.FindGameObjectWithTag("Player").GetComponent<DogeController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void reset()
	{
		transform.position = originalPosition;
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "coin")
		{
			doge.GetComponent<Health>().takeDamage(3);
			Destroy(other.gameObject);
		}
		else if(other.tag == "Player")
		{
			doge.GetComponent<Health>().takeDamage(999999999);
		}
	}
}
