using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {

	public Vector3 direction;
	float lifeTimer;
	public float lifeTime;
	public float speed;

	// Use this for initialization
	void Start () 
	{

		lifeTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{

		lifeTimer += Time.deltaTime;
		if (lifeTimer > lifeTime) 
		{
			Destroy (this.gameObject);
		}

		this.transform.position = this.transform.position + (direction * speed);

	}





}
