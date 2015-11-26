using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {

	Vector2 floorPos;
	float lifeTimer;
	float lifeTime;

	// Use this for initialization
	void Start () 
	{
		lifeTime = 5.0f;
		lifeTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.transform.position.y > floorPos.y)
		{
			this.transform.position = this.transform.position - new Vector3 (0.0f, Time.deltaTime, 0.0f);
		}

		lifeTimer += Time.deltaTime;
		if (lifeTimer > lifeTime)
		{
			Destroy(this.gameObject);
		}
	}

	public void setVariables(Vector2 _floorPos)
	{
		floorPos = (Vector2)_floorPos;
	}



}
