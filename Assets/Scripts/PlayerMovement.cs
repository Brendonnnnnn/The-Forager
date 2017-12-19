using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float jump;
	float moveVelocity;
	bool grounded = false;
	Animator anim ;
	public Vector3 Velo; 

	private bool FacingRW = true;

	// Update is called once per frame


	void Start()
	{
		anim = GetComponent<Animator> ();
	
	}

	void FixedUpdate ()
	{
		anim.SetBool ("isIdle", true);
		Velo = GetComponent<Rigidbody2D> ().velocity;
	
	



		//jump 
		if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown (KeyCode.W))
		{
			if (grounded) {

				anim.SetBool ("isIdle", false);

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (
				GetComponent<Rigidbody2D> ().velocity.x, jump);
				anim.SetBool ("isJumping", true);
		}
		}

		moveVelocity = 0f;

		//Horizontal movement
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			moveVelocity = -speed; //move left
			anim.SetBool ("isIdle", false);
			anim.SetBool ("isJumping", false);
			anim.SetBool ("isRunning", true);
			anim.SetBool ("isDead", false);
			}

		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow))
		{
			if (FacingRW) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;

				FacingRW = false;
			}

		}


		if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow))
		{
			if (!FacingRW) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;

				FacingRW = true;
			}

		}

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			moveVelocity = speed; //move right
			anim.SetBool ("isIdle", false);
			anim.SetBool ("isJumping", false);
			anim.SetBool ("isRunning", true);
			anim.SetBool ("isDead", false);
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveVelocity,
								GetComponent<Rigidbody2D>().velocity.y);



	}

	//check if grounded or not
	void OnTriggerEnter2D(){
	
		grounded = true;
		anim.SetBool ("isIdle", true);
		anim.SetBool ("isJumping", false);
		anim.SetBool ("isRunning", false);
		anim.SetBool ("isDead", false);
		}

	void OnTriggerExit2D(){
	
		grounded = false;
	
		}


	private void Flip (float horizontal)
	{
		if (horizontal < 0 && !FacingRW || horizontal > 0 && FacingRW)
		{
			FacingRW = !FacingRW;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.name == "die")
			
			SceneManager.LoadScene("Lose");
}

}



			


