using UnityEngine;
using System.Collections;

public class RunTexture : MonoBehaviour {
	public Sprite course_1; 
	public Sprite course_2;
	public Sprite course_3;
	public Sprite course_4;
	public Sprite course_5; 
	private SpriteRenderer spriteRenderer; 
	public float countdown = 0.1f;

	// Use this for initialization
	void Start () {

		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = course_1; // set the sprite to sprite1

	}
	
	// Update is called once per frame
	void Update () {

		countdown -= Time.deltaTime;
		if (countdown <= 0.0f)
		{
			changeSprite();
			countdown =0.1f;
		}

	}
	void changeSprite()
	{
		if (spriteRenderer.sprite == course_1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = course_2;
		}
		else if(spriteRenderer.sprite == course_2)
		{
			spriteRenderer.sprite = course_3; // otherwise change it back to sprite1
		}
		else if(spriteRenderer.sprite == course_3)
		{
			spriteRenderer.sprite = course_4; // otherwise change it back to sprite1
		}
		else if(spriteRenderer.sprite == course_4)
		{
			spriteRenderer.sprite = course_5; // otherwise change it back to sprite1
		}
		else if(spriteRenderer.sprite == course_5)
		{
			spriteRenderer.sprite = course_1; // otherwise change it back to sprite1
		}
	}
}
