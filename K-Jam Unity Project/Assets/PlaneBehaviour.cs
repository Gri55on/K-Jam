using UnityEngine;
using System.Collections;

public class PlaneBehaviour : MonoBehaviour {

	public Vector2 forwardForce;
	public float tourqe;
	float lastTourqe;


	// Use this for initialization
	void Start () {

		forwardForce = Vector2.zero;
		tourqe = 0.0f;	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.UpArrow))
		{
			forwardForce = this.transform.right;
		}
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			tourqe = 1.0f;
			lastTourqe = 1.0f;
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			tourqe = -1.0f;
			lastTourqe = 1.0f;
		}


		this.rigidbody2D.AddForce (forwardForce);
		this.rigidbody2D.AddTorque (tourqe);
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

		if (lastTourqe == 1.0f && tourqe > 0)
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
	
	}
}
