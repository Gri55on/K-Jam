using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour 
{
	public Vector3 Velocity = new Vector3(0,0,0);


	void Update ()
	{
		this.transform.position += Velocity;
	}
}
