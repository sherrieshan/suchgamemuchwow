using UnityEngine;
using System.Collections;

public class Houses : MonoBehaviour {

	public float moveDir = 0;
	public float maxSpeed = 3f;
	public float originalXPos;

	// Use this for initialization
	void Start () 
	{
		originalXPos = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
		{
			moveDir = 1f;
		}
		else if(!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
		{
			moveDir = -1f;
		}
		else moveDir = 0;
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
	
	public void reset()
	{
		transform.position = new Vector2(originalXPos, transform.position.y);
	}
}
