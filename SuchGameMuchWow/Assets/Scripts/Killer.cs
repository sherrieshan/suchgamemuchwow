using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {
	
	public Vector3 originalPosition;
	
	// Use this for initialization
	void Start () 
	{
		originalPosition = transform.position;
		GetComponent<Rigidbody>().velocity = new Vector3(1,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void reset()
	{
		transform.position = originalPosition;
	}
}
