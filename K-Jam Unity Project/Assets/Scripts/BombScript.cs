using UnityEngine;
using System.Collections;

public class BombScript : MonoBehaviour {

	Vector2 floorPos;
	float lifeTimer;
	float lifeTime;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		lifeTime = 5.0f;
		lifeTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.transform.position.y > floorPos.y) {
			this.transform.position = this.transform.position - new Vector3 (0.0f, Time.deltaTime, 0.0f);
		}

		lifeTimer += Time.deltaTime;
		if (lifeTimer > lifeTime) {
			Destroy (this.gameObject);
		}

		//Commented out - code for firing the projectile in the planes direction
		/*Vector2 position = transform.localPosition;

		posi		tion = new Vector2 (position.x + speed * Time.deltaTime, position.y);

		transform.localPosition = position;*/
	}

	public void setVariables(Vector2 _floorPos)
	{
		floorPos = (Vector2)_floorPos;
	}



}
