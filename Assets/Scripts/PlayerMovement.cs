using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	#region Attributes
	public float speed = 2;
	public float jumpHeight = 70;

	#endregion
	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void FixedUpdate (){
		checkMovement ();
	}
	void checkMovement()
	{
		Vector2 newPosition = Vector2.zero;
		if (Input.GetKey (KeyCode.RightArrow)) {
			//gauche
			newPosition = Vector2.right * speed * Global.deltaTime;
			transform.eulerAngles = Vector2.zero;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			//droite
			newPosition = Vector2.right * speed * Global.deltaTime;
			transform.eulerAngles = new Vector2 (0, 180);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow) && Global.isGrounded == true)
		{
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight * 5);
		}
		if (IAScript.decision () == 1 && Global.isGrounded == true){
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight * 5);
		}

		transform.Translate(newPosition);
	}
}
