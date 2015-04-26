using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinMaker : MonoBehaviour {

	public Coin coin;
	public float delay = 0;
	public float timeCoinMade = 0;
	public float offset = 0;

	// Use this for initialization
	void Start () 
	{
		delay = Random.Range (15f,65f)/100;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.time - timeCoinMade > delay)
		{
			timeCoinMade = Time.time;
			offset = Random.Range(.5f,7f);
			Instantiate(coin, new Vector2(this.transform.position.x, this.transform.position.y - offset), Quaternion.identity);
		}
	}
}
