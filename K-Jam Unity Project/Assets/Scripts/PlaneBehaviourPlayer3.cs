using UnityEngine;
using System.Collections;

public class PlaneBehaviourPlayer3 : MonoBehaviour 
{		
		public Vector2 forwardForce;
		public float tourqe;
		float tourqeAmount;
		float lastTourqe;
		
		
		// Use this for initialization
		void Start () {
			
			//forwardForce = Vector2.zero;
			tourqe = 0.0f;	
			tourqeAmount = 0.7f;
			
		}
		
		// Update is called once per frame
		void Update () {
			
			//Movement
			if (Input.GetKey (KeyCode.W))
			{
				//forwardForce = this.transform.right;
			}
			forwardForce = this.transform.right;
			if(Input.GetKey (KeyCode.A))
			{
				tourqe = tourqeAmount;
				lastTourqe = tourqeAmount;
			}
			if (Input.GetKey (KeyCode.D))
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
			if(Input.GetKeyDown(KeyCode.LeftShift))
			{
				GameObject instantiatedObj = (GameObject)Instantiate(Resources.Load("Bomb"),this.transform.position + new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
				instantiatedObj.GetComponent<ProjectileScript>().setVariables(this.transform.position);
				
			}
			
			
		}
	}

