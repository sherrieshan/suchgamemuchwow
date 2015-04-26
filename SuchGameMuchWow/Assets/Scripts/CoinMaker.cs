﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinMaker : MonoBehaviour {

	public Coin coin;
	public Orange orange;
	public Bone bone;
	public Twinkie twinkie;
	
	public float delay = 0;
	public float upgradeDelay = 0;
	public float timeCoinMade = 0;
	public float timeUpgradeMade = 0;
	public float offset = 0;

	// Use this for initialization
	void Start () 
	{
		delay = Random.Range (15f,65f)/100;
		upgradeDelay = Random.Range(5,10);
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
		if(Time.time - timeUpgradeMade > upgradeDelay)
		{
			timeUpgradeMade = Time.time;
			offset = Random.Range (.5f,7f);
			switch(Random.Range (1,4))
			{
				case 1:
					Instantiate(orange, new Vector2(this.transform.position.x, this.transform.position.y - offset), Quaternion.identity);
					break;
				case 2:
					Instantiate(bone, new Vector2(this.transform.position.x, this.transform.position.y - offset), Quaternion.identity);
					break;
				case 3:
					Instantiate(twinkie, new Vector2(this.transform.position.x, this.transform.position.y - offset), Quaternion.identity);
					break;
			}
		}
	}
}
