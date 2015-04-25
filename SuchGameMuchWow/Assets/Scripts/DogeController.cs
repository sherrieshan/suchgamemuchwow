using UnityEngine;
using System.Collections;

public class DogeController : MonoBehaviour {

	public float moveDir = 0;
	public bool facingRight = false;
	
	public bool isGrounded = false;
	
	public Animator anim;
	
	public float jumpForce = 700f;
	public float maxSpeed = 5f;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(facingRight && moveDir < 0)
			flip();
		if(!facingRight && moveDir > 0)
			flip();
	}
	
	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * maxSpeed, 0);
		anim.SetFloat("Speed", Mathf.Abs(moveDir));
	}
	
	void flip()
	{
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
