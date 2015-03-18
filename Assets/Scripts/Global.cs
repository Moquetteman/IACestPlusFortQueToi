using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Global : MonoBehaviour {
	public static float deltaTime;
	public static bool isGrounded = false;
	public static Transform player;
	public static int score = 0;
	public static Text scoreText;
//	public static GameObject ground0;


	void Awake(){
		DontDestroyOnLoad(gameObject);
		player = GameObject.FindGameObjectWithTag("Player").transform;
		scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		Physics.gravity *= 2;
		//ground0 = GameObject.FindGameObjectWithTag("Ground0");
		//ground0.translate = Vector3(0,0.5,0.5);

		
		//var go = GameObject.CreatePrimitive(PrimitiveType.Quad);
		//go = (GameObject)Instantiate(Ground0);

		//go.transform.localScale = new Vector3(10,1,0);
	//	go.transform.position = new Vector3(-5,-5,0);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		deltaTime = Time.deltaTime;

		if (player != null)
			Camera.main.transform.position = player.transform.position + new Vector3(0,0,-10);
	
		ShowText();
	
	}

	void ShowText()
	{
		if (scoreText != null) {
			scoreText.text= "score:"+score;	
			scoreText.text += "DT:"+deltaTime;	
			scoreText.transform.name= "TEST";
		}
	}
}
