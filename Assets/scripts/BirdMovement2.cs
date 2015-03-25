using UnityEngine;
using System.Collections;
//using VservPlugin;

public class BirdMovement2 : MonoBehaviour {

	Vector3 velocity = Vector3.zero;

	public static bool is_fire, cubecoll;
	public int click_count;
	//private VservWP8Plugin vservPlugin = new VservWP8Plugin ();

	//public float flapSpeed    = 100f;
	public float flapSpeed    = 5f;
	//public float flapSpeed    = 120f;
	public float forwardSpeed ;
	
	bool didFlap = false;

	public static bool r,l,kr,kr2;

	public bool ratedit,gameoveronce;

	public float coolup;

	public Vector2 force;


	public AudioClip flap,start_game,die,coin ,rormus;

	
	Animator animator;
	
	public bool dead = false;


	public static float b_pos;

	static public float deathCooldown;
	
	public bool godMode = false;

	public int levelno;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();

		is_fire=false;

		force.x = 0;
		force.y = 115;

		cubecoll = false;
		b_pos = transform.position.x;
		click_count =0;

		AudioSource.PlayClipAtPoint(start_game,transform.position);

		if(  int.TryParse(Application.loadedLevelName, out levelno))
		{
		}
		
		if(levelno<=3)
		{
			forwardSpeed = 6f;

		}

		else if(levelno > 3)

		{
			forwardSpeed = 6.066f;
		}


		ratedit = PlayerPrefs.HasKey("ratedit");
		gameoveronce = PlayerPrefs.HasKey("gameoveronce");

		/*vservPlugin.VservAdClosed += HandleAdClosed;
		vservPlugin.SetTestMode (true);*/
		
		if(animator == null) {
			Debug.LogError("Didn't find animator!");
		}
	}


	/*void HandleAdClosed (object sender, System.EventArgs e)
	{
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 1" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 2" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 4" );
		}
		
		else {
			Application.LoadLevel( "gameover" );
		}
	}*/
	
	// Do Graphic & Input updates here
	void Update() {

		b_pos = transform.position.x;

		/*if(monst_movem.is_close)
		{
			this.gameObject.SetActive(false);


		}*/

		if(dead) {

			/*if(rate.has_rated==1)
			{
				vservPlugin.DisplayAd("8063");

				//Time.timeScale =0;
			}*/
			deathCooldown -= Time.deltaTime;
			
			if(deathCooldown <= 0) {

				if(ratedit ==false && gameoveronce)
				{
					Application.LoadLevel( "gameover 3" );
				}


				else{


				/*if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0)) {
					Application.LoadLevel( Application.loadedLevel );
					//pause.ad_avil = false;
				}*/
				if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
				{
					Application.LoadLevel( "gameover 1" );
				}

				else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
				{
					Application.LoadLevel( "gameover 2" );
				}

				else if(ScorePoint_2._score >24)
				{
					Application.LoadLevel( "gameover 4" );
				}

				else {
					Application.LoadLevel( "gameover" );
				}

				}
			}
		}
		else {
			if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) ) {
				didFlap = true;
				click_count++;
				AudioSource.PlayClipAtPoint(flap,transform.position);
			
			}

		}


		/*if (Input.GetKey(KeyCode.Escape)) 
		{
			
			Application.LoadLevel("scene_2");
			/*if (isInMenu) 
			{
				ToggleMenu(); 
			}
			else {
				Application.Quit();
			} */
			
		//}
	}
	
	
	// Do physics engine updates here
	void FixedUpdate () {

		if(button_play.pl_clicked == false)
		{
			rigidbody2D.gravityScale =0;
			rigidbody2D.angularDrag=0;

		}

		else{

			//rigidbody2D.gravityScale =1.29f;
			rigidbody2D.gravityScale =1.07f;
			rigidbody2D.angularDrag=0.05f;
			button_play.pl_clicked = true;
		}

		if(dead || button_play.pl_clicked == false)
			return;
		
		//rigidbody2D.AddForce( Vector2.right * forwardSpeed );
		
		if(didFlap) {

			//rigidbody2D.AddForce( Vector2.up * flapSpeed);
			
			Vector3 vel =rigidbody2D.velocity;
			
			//vel.y +=flapSpeed*Time.deltaTime;

			vel.y =0f;
			//vel.x = 7f;
			//vel.x = 5.81f;
			vel.x = forwardSpeed;
			//animator.SetTrigger("DoFlap");
			
			rigidbody2D.velocity = vel;

			rigidbody2D.AddForce(force);
			
			didFlap = false;
		}
		
		/*if(rigidbody2D.velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {*/

		if(button_play.pl_clicked == true)
		{
			float angle = Mathf.Lerp (0, -90, (-rigidbody2D.velocity.y / 2f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}

		//}
	}


	void playroar()
	{
		
		/*if(!gmmus || GameObject.Find("gmloop"))
		{
			return;
		}
		*/
		GameObject	go_gm = new GameObject("gmloop");
		AudioSource gmloop_as = go_gm.AddComponent<AudioSource>();
		gmloop_as.clip = rormus;

		

			if(gmloop_as.isPlaying == true)
			{
			//gmloop_as.Stop();
			//gmloop_as.Play();

			//Destroy(go_gm,rormus.length);
				//Destroy(go,bgmus.length);

			return;
			}

		else{
			gmloop_as.Play();
		}

	}

			
			

		//Destroy(go_gm,gmmus.length);

	
		

	
	void OnCollisionEnter2D(Collision2D collision) {
		/*if(godMode)
			return;*/
		
		//animator.SetTrigger("Death");
		//dead = true;
		AudioSource.PlayClipAtPoint(die,transform.position);
		//playroar();

	
	

		deathCooldown = 0.33f;
		if(collision.collider.tag == "pipe_2")
		{
		r= true;
		}

		if(collision.collider.tag =="kill_pipe")
		{
			kr= true;
		}

		if(collision.collider.tag =="kill_pipe2")
		{
			kr2 = true;
		}

		if(collision.collider.tag =="goldgun")
		{
			AudioSource.PlayClipAtPoint(coin,transform.position);
		}

		if(collision.collider.tag =="deathcube")
		{
			cubecoll = true;
		}

		/*if(collision.collider.tag =="lightning")

		{
			l= true;

		}*/

		//deathCooldown = 0;



	}



	/*void OnTriggerEnter2D(Collider2D collider) {
		
		if(collider.tag == "fire")
		{
			BirdMovement2.is_fire = true;
			firemonst.q= true;
		}
		
	}*/


}
