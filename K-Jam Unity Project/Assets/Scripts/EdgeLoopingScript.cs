using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EdgeLoopingScript : MonoBehaviour 
{


	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}

    //If the object leaves the play area collider transport it to the other side of the collider
	void OnTriggerExit2D(Collider2D collision) 
	{
		if(collision.transform.position.x >= this.transform.position.x + (this.transform.localScale.x/2))
		{
			collision.transform.position = new Vector3(-(this.transform.localScale.x/2),collision.transform.position.y, 0.0f);
		}
		else if(collision.transform.position.x <= this.transform.position.x - (this.transform.localScale.x/2))
		{
			collision.transform.position = new Vector3((this.transform.localScale.x/2),collision.transform.position.y, 0.0f);
		}
		else if(collision.transform.position.y >= this.transform.position.y + (this.transform.localScale.y/2))
		{
			collision.transform.position = new Vector3(collision.transform.position.x,-(this.transform.localScale.y/2), 0.0f);
		}
		else if(collision.transform.position.y <= this.transform.position.y - (this.transform.localScale.y/2))
		{
			collision.transform.position = new Vector3(collision.transform.position.x,(this.transform.localScale.y/2), 0.0f);
		}
	}

}
