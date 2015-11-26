using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour 
{
	public Vector3 Velocity = new Vector3(0,0,0);
	// Update is called once per frame

	void Update ()
	{
		this.transform.position += Velocity;
	}
}
