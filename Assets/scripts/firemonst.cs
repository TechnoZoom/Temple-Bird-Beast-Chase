using UnityEngine;
using System.Collections;

public class firemonst : MonoBehaviour {

	public float tm;

	GameObject bird,monster;

	public  bool q,r,s;

	float pipeMax = 5.127078f;
	float pipeMin = -2.842603f;

	public float fire_y;

	Vector3 fire_pos;
	// Use this for initialization
	void Start () {
	
		//this.enabled = false;
		tm =2f;

		q = false;

		bird = GameObject.FindGameObjectWithTag("Player");
		monster = GameObject.FindGameObjectWithTag("monster");

		fire_pos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
		//Vector3 fire_pos = transform.position;
		
		//fire_pos.x = transform.position.x;

		//transform.Translate(Vector3.right * Time.deltaTime*3);


		/*Vector3 pos = transform.position;
		
		//pos.x +=1.0f*Time.deltaTime;
		
		transform.position = pos;*/

		
		//transform.position = fire_pos;

		//tm-=Time.deltaTime;


			//this.enabled = true;


		if(q)
		{


			tm -=Time.deltaTime;
		}

		if(!q || tm<=0)
		{
			transform.Translate(Time.deltaTime*2,0,0);
			//tm =2f;

		}

		if(tm<=0 && q)

		{
			q = false;
			BirdMovement2.is_fire= false;
			tm =2f;
		}

	

			if((transform.position.x - bird.transform.position.x)>=4f)

			{
				//this.enabled = false;
				fire_pos.x = monster.transform.position.x+3f;
				transform.position = fire_pos;
			    fire_y = Random.Range(pipeMin,pipeMax);
			    //BirdMovement2.is_fire= false;

		}



	}

	/*void OnTriggerEnter2D(Collider2D collider) {
		
		if(collider.tag == "Player")
		{
			BirdMovement2.is_fire = true;
			q= true;
		}
		
	}*/


	void OnCollisionEnter2D(Collision2D collision) {

		if(collision.collider.tag == "Player")

		{
			fire_pos.x = monster.transform.position.x+3f;
			transform.position = fire_pos;
			//BirdMovement2.is_fire = true;
			q= true;


		}

	}

}
