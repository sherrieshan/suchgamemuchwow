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
		doge.moveDir = 0;
		if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
		{
			doge.moveDir = -1f;
		}
		if(!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
		{
			doge.moveDir = 1f;
		}
	}
}
