using UnityEngine;
using System.Collections;

public class AsteroidSpawn : MonoBehaviour 
{

	Asteroid asteroidScript;	    //The asteroid script on the gameobject spawned (Handles Velocity)
	GameObject[] asteroidList;		//List of all asteroids in the scene
	public GameObject asteroid;	        //The asteroid gameobject to be instansiated
	public Vector3 Velocity;
    public int amount, minPos, maxPos, minspeed, maxSpeed;

	void Start()
	{
		Spawn ();
	}

	void Spawn()
	{
        asteroidList = new GameObject[amount]; 
		//Spawns a number of asteroids (i)
		for (int i = 0; i < amount; i++) 
		{
			asteroidList[i] = GameObject.Instantiate(asteroid, RandomPos(), Quaternion.identity) as GameObject;
		}

		//Set the velocity for each asteroid in the asteroids array
		foreach (GameObject ast in asteroidList) 
		{
            asteroidScript = ast.GetComponent<Asteroid>();
            asteroidScript.Velocity = RandomVel();
		}
	}

	//Returns a random position within the min/max position values
	Vector3 RandomPos()
	{
		int x, y, z;
		x = UnityEngine.Random.Range (minPos, maxPos);
		y = UnityEngine.Random.Range (minPos, maxPos);
		z = 0;
		return new Vector3 (x,y,z);
	}

	//Returns a random velocity between the min/max speed
	Vector3 RandomVel()
	{
		int x, y, z;
		x = UnityEngine.Random.Range (minspeed, maxSpeed);
		y = UnityEngine.Random.Range (minspeed, maxSpeed);
		z = 0;
		return new Vector3 (x, y, z);
	}
}
