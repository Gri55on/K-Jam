using UnityEngine;
using System.Collections;

public class BombDrop : MonoBehaviour
{		
	void Start ()
	{
	
	}
	
	void OnTriggerEnter2D(Collider2D inCollider)
	{
		if (inCollider.gameObject.tag == "Building") 
		{
			Destroy(this.gameObject);
		}
	}

}