using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour 
{
    //Assigned in Asteroid manager, initialized for redundancy
	public Vector3 Velocity = new Vector3(0,0,0);
    public float Size = 1f; 


    void Start()
    {
        Rigidbody2D asteroidBody = this.GetComponent<Rigidbody2D>();
        Transform asteroidTrans = this.GetComponent<Transform>(); 
       
        asteroidBody.mass = Size;
        asteroidTrans.localScale = new Vector3(Size, Size,0.1f);
        
        Velocity = new Vector3(Velocity.x / Size, Velocity.y / Size, 0);
    }


	void Update ()
	{
		this.transform.position += Velocity;
	}
}
