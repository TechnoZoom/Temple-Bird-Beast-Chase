using UnityEngine;
using System.Collections;

public class laser_bird_coll : MonoBehaviour {

	public float cooldown;

	public static int attack_count;

	public static bool f;

	// Use this for initialization
	void Start () {
	
		attack_count =0;
		cooldown = 1.8f;
		f = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(BirdMovement2.l == true)
		{
			cooldown -= Time.deltaTime;
		}

		if(cooldown<=0)
		{
			cooldown = 1.8f;
			BirdMovement2.l = false;

			attack_count++;
			f = true;
			


		}

		//f= false;

	}


	void OnCollisionEnter2D(Collision2D collision) {
		
		if(collision.collider.tag =="Player")
			
		{
			
			//Debug.Log("dfghjkdfghjdfghjfghjfdghjfghjfghfg");
			BirdMovement2.l = true;
			
			
			
		}
		
	}

	void OnTriggerEnter2D(Collider2D collider) {

		if(collider.tag =="Player")
			
		{
			
			//Debug.Log("dfghjkdfghjdfghjfghjfdghjfghjfghfg");
			BirdMovement2.l = true;
			
			
			
		}

	}
}
