using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour 
{
	public Vector3 Velocity;
	// Update is called once per frame

	void Update ()
	{
		this.transform.position += Velocity;
	}
}
