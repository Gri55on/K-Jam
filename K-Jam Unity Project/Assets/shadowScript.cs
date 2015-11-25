using UnityEngine;
using System.Collections;

public class shadowScript : MonoBehaviour {

	public GameObject shadow;
	float height;

	// Use this for initialization
	void Start () {

		height = 0.0f;	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			if (height < 1.0f) 
			{
			height += Time.deltaTime;
			}
			else 
			{
				height = 1.0f;
			}			
		}
		else
		{
			if(height > 0.0f)
			{
				height -= Time.deltaTime;
			}
			else
			{
				height = 0.0f;
			}
		}

		this.transform.position = shadow.transform.position + new Vector3 (0.0f, height);
		this.transform.rotation = shadow.transform.rotation;

		Vector2.SqrMagnitude (shadow.rigidbody2D.velocity);


	}
}
