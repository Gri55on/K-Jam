﻿using UnityEngine;
using System.Collections;

public class AsteroidSpawn : MonoBehaviour 
{

	//Asteroid asteroidScript;	//The asteroid script (Handles Velocity)
	GameObject[] asteroids;		//List of all asteroids in the scene
	GameObject asteroid;	//The asteroid gameobject to be spawned
	public int amount, minPos, maxPos, minspeed, maxSpeed;
	public Vector3 Velocity;

	void Start()
	{
		Spawn ();
	}

	void Spawn()
	{
		//Spawns a number of asteroids (i)
		for (int i = 0; i < amount; i++) 
		{
			asteroids[i] = Instantiate(asteroid, RandomPos(), Quaternion.identity) as GameObject;
		}



		//Set the velocity for each asteroid in the asteroids array
		/*foreach (GameObject ast in asteroids) 
		{
			asteroidScript = ast.GetComponents<Asteroid>();
			asteroidScript.Velocity = RandomVel();
		}*/
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

	//Returns a random velocity between 
	Vector3 RandomVel()
	{
		int x, y, z;
		x = UnityEngine.Random.Range (minspeed, maxSpeed);
		y = UnityEngine.Random.Range (minspeed, maxSpeed);
		z = 0;
		return new Vector3 (x, y, z);
	}

	void update()
	{
		this.transform.position += RandomVel;
	}
}