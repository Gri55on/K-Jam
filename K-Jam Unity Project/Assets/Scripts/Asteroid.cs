using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour 
{
    //Assigned in Asteroid manager, initialized for redundancy
	public Vector3 Velocity = new Vector3(0,0,0);
    public float Size = 1.0f; 


    void Start()
    {
        Rigidbody2D asteroidBody = this.GetComponent<Rigidbody2D>();
        Transform asteroidTrans = this.GetComponent<Transform>(); 
       
        //asteroidBody.mass = Size;
        asteroidTrans.localScale = new Vector3(Size, Size,0.1f);
		if (this.GetComponent<BoxCollider2D> () == null) 
		{
			this.gameObject.AddComponent<BoxCollider2D>();
		}
        
        Velocity = new Vector3(Velocity.x / Size, Velocity.y / Size, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy bullets that colide with the asteroid
        if ( other.tag == "Bullet")
        {
            Destroy(other.gameObject);
			FindObjectOfType<AsteroidManager> ().asteroidSplit (this.gameObject);
        }
		if (other.tag == "Player")
		{
			other.GetComponent<SpaceshipBehaviour>().killed();            
			//kil player, lives etc
			FindObjectOfType<AsteroidManager> ().asteroidSplit (this.gameObject);
		}
        //Kill the player if it collides with the asteroid
       


        //Call asteroid split here

    }

	void OnColliderEnter2D(Collider2D other)
	{

	}

	void Update ()
	{
		this.transform.position += Velocity;
	}
}
