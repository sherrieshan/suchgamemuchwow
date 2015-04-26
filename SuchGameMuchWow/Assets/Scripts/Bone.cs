using UnityEngine;
using System.Collections;

public class Bone : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(-3f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if(other.tag == "Player")
		{
			DogeController doge = other.gameObject.GetComponent<DogeController>();
			doge.setDoge(true);
			Destroy(this.gameObject);
		}
	}
}
