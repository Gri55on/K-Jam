using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AsteroidManager : MonoBehaviour 
{
    List<GameObject> asteroidList = new List<GameObject>();     //List of asteroids
	Asteroid asteroidScript;	                                //The asteroid script on the gameobject spawned (Handles Velocity)
	public GameObject asteroid;	                                //The asteroid gameobject to be instansiated
	public Vector3 Velocity;
	public int amount;
    public float minPos, maxPos, minspeed, maxSpeed;

	void Start()
	{
        
		Spawn ();
	}

	void Spawn()
	{
		//Spawns a number of asteroids (i)
		for (int i = 0; i < amount; i++) 
		{
           GameObject newAsteroid = (GameObject)Instantiate(asteroid, RandomPos(), Quaternion.identity);
           asteroidList.Add(newAsteroid);
		}

		//Set the velocity for each asteroid in the asteroids array
		foreach (GameObject ast in asteroidList) 
		{
            asteroidScript = ast.GetComponent<Asteroid>();
            asteroidScript.Velocity = RandomVel();
		}
	}

    //Splits the asteroid and spawns two smaller asteroids
    void asteroidSplit(GameObject asteroidToSplit)
    {
        
    }

	//Returns a random position within the min/max position values
	Vector3 RandomPos()
	{
		float x, y, z;
		x = UnityEngine.Random.Range (minPos, maxPos);
		y = UnityEngine.Random.Range (minPos, maxPos);
		z = 0;
		return new Vector3 (x,y,z);
	}

	//Returns a random velocity between the min/max speed
	Vector3 RandomVel()
	{
		float x, y, z;
		x = UnityEngine.Random.Range (minspeed, maxSpeed);
		y = UnityEngine.Random.Range (minspeed, maxSpeed);
		z = 0;
		return new Vector3 (x, y, z);
	}
}
