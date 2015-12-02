using UnityEngine;
using System.Collections;

public class PlaneBehaviour : MonoBehaviour {

	public Vector2 forwardForce;
	public float tourqe;
	float tourqeAmount;
	float lastTourqe;
	public int playerNo;


	// Use this for initialization
	void Start () {

		//forwardForce = Vector2.zero;
		tourqe = 0.0f;	
		tourqeAmount = 0.7f;

	}
		
	// Update is called once per frame
	void Update () {

		//Movement
		if (Input.GetKey (KeyCode.UpArrow) && playerNo == 1 || Input.GetKey (KeyCode.Keypad8) && playerNo == 2
		    ||Input.GetKey (KeyCode.W) && playerNo == 3 ||Input.GetKey (KeyCode.O) && playerNo == 4)
		{
			forwardForce = this.transform.right;
		}
		forwardForce = this.transform.right;
		if (Input.GetKey (KeyCode.LeftArrow) && playerNo == 1 || Input.GetKey (KeyCode.Keypad4) && playerNo == 2
		    ||Input.GetKey (KeyCode.A) && playerNo == 3 ||Input.GetKey (KeyCode.K) && playerNo == 4)
		{
			tourqe = tourqeAmount;
			lastTourqe = tourqeAmount;
		}
		if (Input.GetKey (KeyCode.RightArrow) && playerNo == 1 || Input.GetKey (KeyCode.Keypad6) && playerNo == 2
		    ||Input.GetKey (KeyCode.D) && playerNo == 3 ||Input.GetKey (KeyCode.Semicolon) && playerNo == 4)
		{
			tourqe = -tourqeAmount;
			lastTourqe = -tourqeAmount;
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


		//Dropping bombs
		if (Input.GetKeyDown (KeyCode.Space) && playerNo == 1 || Input.GetKeyDown (KeyCode.KeypadEnter) && playerNo == 2
		    ||Input.GetKeyDown (KeyCode.LeftShift) && playerNo == 3 ||Input.GetKeyDown (KeyCode.RightShift) && playerNo == 4)
		{
			GameObject instantiatedObj = (GameObject)Instantiate(Resources.Load("Bomb"),this.transform.position + new Vector3(0.0f, 1.0f, 0.0f), this.transform.rotation);
			instantiatedObj.GetComponent<BombScript>().setVariables(this.transform.position);
		}

	}

	public void killed()
	{
		this.gameObject.SetActive (false);
		this.gameObject.transform.position = new Vector3(0f, 0f, 0f);

		float time = Time.deltaTime;
		if (Time.deltaTime < time + 5.0f) 
		{
			Debug.Log(Time.deltaTime);
		}
		this.gameObject.SetActive(true);
	}
}
