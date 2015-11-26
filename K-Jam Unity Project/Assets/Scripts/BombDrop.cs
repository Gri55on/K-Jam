using UnityEngine;
using System.Collections;

public class BombDrop : MonoBehaviour
{		
	int score = 0;
	//string scoreText = "Score: 0";

	void Start()
	{
		//FindObjectOfType<Canvas>().GetComponentInChildren<TextMesh>().text = "Score: " + score;
	}
	
	void OnTriggerEnter2D(Collider2D inCollider)
	{
		if (inCollider.gameObject.tag == "Bomb") 
		{
			Destroy(this.gameObject);
			score += 10;
//			GetComponentInChildren<TextMesh>().text = "Score: " + score;

			//scoreText = "Score: " + score;


		}
	}

}