using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D obj)
	{
		switch (obj.tag) 
		{
			case "Coin":
				Global.score++;
				Destroy (obj.gameObject);
				break;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
