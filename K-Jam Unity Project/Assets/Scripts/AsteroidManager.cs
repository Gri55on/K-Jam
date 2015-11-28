using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AsteroidManager : MonoBehaviour 
{
    List<GameObject> asteroidList = new List<GameObject>();     //List of asteroids
	Asteroid asteroidScript;	                                //The asteroid script on the gameobject spawned (Handles Velocity)
	public GameObject asteroid;	                                //The asteroid gameobject to be instansiated
	public Vector3 Velocity;
    public int amount, minPos, maxPos, minspeed, maxSpeed,split;


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

    //Splits the asteroid and spawns a number of smaller asteroids 
    void asteroidSplit(GameObject asteroidToSplit)
    {
        for (int i = 0; i < split; i++)
        {
            //Spawn new asteroids and add them to the list
            GameObject addedAsteroiid = GameObject.Instantiate(asteroid, asteroidToSplit.transform.position, Quaternion.identity) as GameObject;
            asteroidList.Add(addedAsteroiid);
        }
        //Remove asteroid from list then destroy it
        asteroidList.Remove(asteroidToSplit);
        GameObject.Destroy(asteroidToSplit);
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
