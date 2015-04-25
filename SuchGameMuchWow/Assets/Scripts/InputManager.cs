using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public DogeController doge;
	
	// Use this for initialization
	void Start () 
	{
		doge = GameObject.FindGameObjectWithTag("Player").GetComponent<DogeController>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
		{
			doge.moveDir = -1f;
		}
		else if(!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
		{
			doge.moveDir = 1f;
		}
		else doge.moveDir = 0;
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			doge.jump();
		}
	}
}
