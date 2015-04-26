using UnityEngine;
using System.Collections;

public class DogeController : MonoBehaviour {

	public float moveDir = 0;
	public bool facingRight = true;
	
	public bool isGrounded = false;
	
	public bool isTwinkie = false;
	
	public Animator anim;
	public Transform groundCheck;
	public LayerMask groundMask;
	
	public float jumpForce = 700f;
	public float maxSpeed = 5f;

	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator> ();
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
		isGrounded = Physics2D.OverlapPoint (groundCheck.position, groundMask);
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		anim.SetFloat("Speed", Mathf.Abs(moveDir));
	}
	
	void flip()
	{
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
	
	public void jump()
	{
		Debug.Log ("Jumping");
		if(isGrounded)
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300f));
	}
	
	public void setTwinkie(bool t)
	{
		isTwinkie = t;
		anim.SetBool("Twinkie", isTwinkie);
	}
}
