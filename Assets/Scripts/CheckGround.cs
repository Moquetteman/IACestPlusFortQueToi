using UnityEngine;
using System.Collections;

public class CheckGround : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.gameObject.layer == 8 && !Global.isGrounded)
		{
			Global.isGrounded = true;
			transform.name= "GROUNDED"+obj.gameObject.layer;
		}
		else transform.name= "test1"+obj.gameObject.layer;
	}
	void OnTriggerExit2D(Collider2D obj)
	{

		if(obj.gameObject.layer == 8 && Global.isGrounded)
		{
			Global.isGrounded = false;
			transform.name= "NOT GROUNDED"+obj.gameObject.layer;
		}
		else transform.name= "test2"+obj.gameObject.layer;
	}


	void OnTriggerStay2D(Collider2D obj)
	{
		if(obj.gameObject.layer == 8)
		{
			Global.isGrounded = true;
			transform.name= "GROUNDED"+obj.gameObject.layer;
		}
		else transform.name= "test1"+obj.gameObject.layer;
	}
}
