using System.Collections.Generic;
using System.Linq;

using UnityEngine;

/// <summary>
/// Parallax scrolling
/// </summary>
public class GroundScrollingScript : MonoBehaviour
{
	/// <summary>
	/// Vitesse du défilement
	/// </summary>
	public Vector2 speed = new Vector2(2, 2);

	/// <summary>
	/// Direction du défilement
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	
	/// <summary>
	/// Appliquer le mouvement de scrolling à la caméra ?
	/// </summary>
	public bool isLinkedToCamera = false;
	
	/// <summary>
	/// 1 - Le plan est infini
	/// </summary>
	public bool isLooping = false;
	
	/// <summary>
	/// 2 - Liste des enfants avec renderer
	/// </summary>
	private List<Transform> backgroundPart;
	
	// 3 - Récupération des objets enfants du plan
	void Start()
	{
		/*
		 * // Pour la réptition
		if (isLooping)
		{
			// On récupère les objets enfants qui ont un renderer
			backgroundPart = new List<Transform>();
			
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				
				if (child.renderer != null)
				{
					backgroundPart.Add(child);
				}
			}
			
			// Tri par position
			// Note : cela n'est bon que pour un défilement de gauche à droite
			// il faudrait modifier un peu pour gérer d'autres directions.
			backgroundPart = backgroundPart.OrderBy(
				t => t.position.x
				).ToList();
		}*/
	}
	
	void Update()
	{
		// Mouvement
		Vector3 movement = new Vector3(
			speed.x * direction.x,
			speed.y * direction.y,
			0);
		
		movement *= Time.deltaTime;
		transform.Translate(movement);

		//position droite de la camera
		float camRightBorder = Camera.main.orthographicSize * Screen.width / Screen.height;
		float camLeftBorder = -camRightBorder;
		float test = Camera.main.orthographicSize * 2 * Screen.width / Screen.height;
	//	transform.name= camRightBorder.ToString();
	//	int width = (int)renderer.bounds.size.x;
		transform.name= camLeftBorder.ToString();

		//si la droite de la texture atteint le bord gauche de la camera
		if (this.transform.position.x < camLeftBorder-10/2) {
		
			this.transform.Translate(9.9f*4,0,0);
		} 
		//transform.name = transform.position.x.ToString();
		//transform.right
		// Défilement camera
		/*
		if (isLinkedToCamera)
		{
			Camera.main.transform.Translate(movement);
		}

		// 4 - Répétition
		if (isLooping)
		{
			//transform.name= "TEST loop";
			// On prend le premier objet (la la liste est ordonnée)
			Transform firstChild = backgroundPart.FirstOrDefault();
			
			if (firstChild != null)
			{
				// Premier test sur la position de l'objet
				// Cela évite d'appeler directement IsVisibleFrom
				// qui est assez lourde à exécuter
				if (firstChild.position.x < Camera.main.transform.position.x)
				{
					// On vérifie maintenant s'il n'est plus visible de la caméra
					if (firstChild.renderer.IsVisibleFrom(Camera.main) == false)
					{
						transform.name= "TEST 1";
						// On récupère le dernier élément de la liste
						Transform lastChild = backgroundPart.LastOrDefault();
						
						// On calcule ainsi la position à laquelle nous allons replacer notre morceau
						Vector3 lastPosition = lastChild.transform.position;
						Vector3 lastSize = (lastChild.renderer.bounds.max - lastChild.renderer.bounds.min);
						
						// On place le morceau tout à la fin
						// Note : ne fonctionne que pour un scorlling horizontal
						firstChild.position = new Vector3(lastPosition.x + lastSize.x, firstChild.position.y, firstChild.position.z);
						
						// On met à jour la liste (le premier devient dernier)
						backgroundPart.Remove(firstChild);
						backgroundPart.Add(firstChild);
					}
					else transform.name= "TEST 2";
				}
			}
		}*/
	}
}
