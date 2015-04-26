using UnityEngine;
using System.Collections;

public class DogeController : MonoBehaviour {

	public float moveDir = 0;
	public float yDir = 0;
	public bool facingRight = true;
	
	public bool isGrounded = false;

	public bool isDoge = true;
	public bool isTwinkie = false;
	public bool isOrange = false;
	
	public Animator anim;
	public Transform groundCheck;
	public LayerMask groundMask;
	public float timeHitRightWall = 0;
	
	public float jumpForce = 1000f;
	public float maxSpeed = 5f;
	
	public AudioSource audios;
	public AudioClip jumpSound;

	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator> ();
		audios = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<AudioSource>();
		anim.SetBool("Doge", isDoge);
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
		if(isDoge)
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		else if(isTwinkie)
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * maxSpeed, yDir * maxSpeed*2f/3f);
		else if(isOrange)
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveDir * maxSpeed * 1.5f, GetComponent<Rigidbody2D>().velocity.y);
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
		if(isGrounded && !isTwinkie)
		{
			audios.PlayOneShot(jumpSound);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 350f + (isOrange? 250f : 0f)));
		}
		else if(isOrange && transform.position.y < 0)
		{
			audios.PlayOneShot(jumpSound);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300f + (isOrange? 300f : 0f)));
		}
	}
	
	public void setTwinkie(bool t)
	{
		isTwinkie = t;
		anim.SetBool("Twinkie", isTwinkie);
		isOrange = !t;
		anim.SetBool("Orange", isOrange);
		isDoge = !t;
		anim.SetBool("Doge", isDoge);
		GetComponent<Rigidbody2D>().gravityScale = 0;
	}

	public void setOrange(bool t)
	{
		isOrange = t;
		anim.SetBool("Orange", isOrange);
		isDoge = !t;
		anim.SetBool("Doge", isDoge);
		isTwinkie = !t;
		anim.SetBool("Twinkie", isTwinkie);
		GetComponent<Rigidbody2D>().gravityScale = 1;
	}

	public void setDoge(bool t)
	{
		isDoge = t;
		anim.SetBool("Doge", isDoge);
		isOrange = !t;
		anim.SetBool("Orange", isOrange);
		isTwinkie = !t;
		anim.SetBool("Twinkie", isTwinkie);
		GetComponent<Rigidbody2D>().gravityScale = 1;
	}
}
