using UnityEngine;
using System.Collections;

public class WallTrigger : MonoBehaviour {
	GameObject dogeTrig;
	float posX;

	// Use this for initialization
	void Start () {
		dogeTrig = GameObject.FindGameObjectWithTag ("Player");
		posX = dogeTrig.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			float y = other.GetComponent<Transform>().position.y;
			other.GetComponent<Transform>().position = new Vector2(posX, y);
		}
	}
}
