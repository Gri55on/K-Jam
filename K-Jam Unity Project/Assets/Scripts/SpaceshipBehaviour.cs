using UnityEngine;
using System.Collections;

public class SpaceshipBehaviour : MonoBehaviour {
	
	public Vector2 forwardForce;
	public float tourqe;
	float tourqeAmount;
	float lastTourqe;
	public float xr,yr;
	
	// Use this for initialization
	void Start () {
		
		//forwardForce = Vector2.zero;
		tourqe = 0.0f;	
		tourqeAmount = 2f;
		xr = Random.Range(-4.5f, 4.5f);
		yr = Random.Range(-4.5f, 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
		//Movement
		if (Input.GetKey (KeyCode.UpArrow))
		{
			forwardForce = this.transform.right;
		}
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			tourqe = tourqeAmount;
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			tourqe = -tourqeAmount;
		}

		//Hyperspace
		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			transform.position = new Vector3(xr,yr,0.0f);
			xr = Random.Range(-4.5f, 4.5f);
			yr = Random.Range(-4.5f, 4.5f);

		}
		
		this.GetComponent<Rigidbody2D>().AddForce (forwardForce);
		this.GetComponent<Rigidbody2D>().AddTorque (tourqe);
		if (forwardForce.x > 0) 
		{
			forwardForce.x -= Time.deltaTime;
		} 
		else
		{
			forwardForce.x = 0;
		}
		if (forwardForce.y > 0) 
		{
			forwardForce.y -= Time.deltaTime;
		} 
		else
		{
			forwardForce.y = 0;
		}
		
		if (lastTourqe ==1.0f && tourqe > 0)
		{
			tourqe -= Time.deltaTime;
		} 
		else if (lastTourqe == -1.0f && tourqe < 0)
		{
			tourqe += Time.deltaTime;
		}
		else
		{
			tourqe = 0.0f;
		}

		//Shooting Bullet
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject instantiatedObj = (GameObject)Instantiate(Resources.Load("Bullet"),this.transform.position, this.transform.rotation);
			instantiatedObj.GetComponent<ProjectileScript>().direction = Vector3.Normalize(this.transform.right);			
		}



		
		
	}
}
