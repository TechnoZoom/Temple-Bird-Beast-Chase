using UnityEngine;
using System.Collections;

using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class monst_movem : MonoBehaviour {


	Animator anim,an,kil_pi_an,kil_pi_an2;

	private InterstitialAd interstitial;

	string level_name;
	public static int level_number;

	public static bool is_close,gameover,win;

	public AudioClip bg;

	public AudioClip tada, ting;

	public AudioSource bgas;

	public int attack_count;

	public int tada_count,ting_count,bgstop_count;

	public bool _isstop;

	public static int c;

	 /*GameObject bgloop;

	AudioSource bgloop_as;*/

	GameObject g,home,restrt,next,b,gmovertext,lvlcomp,gold,silver,bronze,timetaken,st1,st2,st3,stdr1,stdr2,stdr3,kilp1,kilp2 ,ratebox;

	public float dist;

	public static float coolup;

	public static float tm;

	public AudioClip bgmus,gmmus;

	public int levelno;

	string package_name = "com.TechnoZoom.testtemple" ;

	//AdSize adSize ;
	//BannerView bannerView;



	void playbgmusic(bool isstop)
	{

		if(!bgmus || GameObject.Find("bgloop"))
		{
			return;
		}
		
	GameObject	go = new GameObject("bgloop");
		AudioSource bgloop_as = go.AddComponent<AudioSource>();
		bgloop_as.clip = bgmus;
		bgloop_as.loop = true;

		if(_isstop)
		{
			if(bgloop_as.isPlaying)
			{
				bgloop_as.Stop();
				//Destroy(go,bgmus.length);
			}
		}

		else{

		  bgloop_as.Play();
		}
		Destroy(go,bgmus.length);

	}

	void playgmovmusic(bool isstop)
	{
		
		if(!gmmus || GameObject.Find("gmloop"))
		{
			return;
		}
		
		GameObject	go_gm = new GameObject("gmloop");
		AudioSource gmloop_as = go_gm.AddComponent<AudioSource>();
		gmloop_as.clip = gmmus;
		gmloop_as.loop = true;
		
		if(_isstop)
		{
			if(gmloop_as.isPlaying)
			{
				gmloop_as.Stop();
				//Destroy(go,bgmus.length);
			}
		}
		
		else{
			
			gmloop_as.Play();
		}
		Destroy(go_gm,gmmus.length);
		
	}



	// Use this for initialization
	void Start () {

		c++;

		if(  int.TryParse(Application.loadedLevelName, out levelno))
		{
		}

		else{
				levelno = 1;
		}




		if(c%4 == 3)
		{
		RequestInterstitial();
		}

		//adSize = new AdSize(250, 250);
          
		Debug.Log (c);

		/*bannerView = new BannerView(
			"ca-app-pub-1177092011471737/5766757009", AdSize.Banner, AdPosition.Bottom);


		bannerView.LoadAd(createAdRequest());

		bannerView.Hide();*/

		anim = transform.GetComponentInChildren<Animator>();

		tada_count = 0;

		bgstop_count = 0;
		//audio.clip = bg;

		//bgas = this.GetComponent<AudioSource>();

		/*if(!bgmus || GameObject.Find("bgloop"))
		{
			return;
		}

		bgloop = new GameObject("bgloop");
		bgloop_as = bgloop.GetComponent<AudioSource>();
		bgloop_as.clip = bgmus;
		bgloop_as.loop = true;*/

		_isstop = false;

		level_name = Application.loadedLevelName;

		level_number = int.Parse(level_name);

		g = GameObject.FindGameObjectWithTag("li");

		home = GameObject.FindGameObjectWithTag("home");
		
		restrt = GameObject.FindGameObjectWithTag("restart");

		gmovertext = GameObject.FindGameObjectWithTag("gmovertext");

		lvlcomp = GameObject.FindGameObjectWithTag("lvlcomp");
		
		next = GameObject.FindGameObjectWithTag("next");
		b= GameObject.FindGameObjectWithTag("Player");

		gold = GameObject.FindGameObjectWithTag("gold");
		silver = GameObject.FindGameObjectWithTag("silver");
		bronze = GameObject.FindGameObjectWithTag("bronze");

		timetaken = GameObject.FindGameObjectWithTag("timetaken");

		st1 = GameObject.FindGameObjectWithTag("st1");
		st2 = GameObject.FindGameObjectWithTag("st2");
		st3 = GameObject.FindGameObjectWithTag("st3");

		stdr1 = GameObject.FindGameObjectWithTag("stdr1");
		stdr2 = GameObject.FindGameObjectWithTag("stdr2");
		stdr3 = GameObject.FindGameObjectWithTag("stdr3");

		kilp1 = GameObject.FindGameObjectWithTag("kill_pipe_pr");
		kilp2 = GameObject.FindGameObjectWithTag("kill_pipe_pr2");

		ratebox = GameObject.FindGameObjectWithTag("rate");

		if(kilp2!= null)
		{
		//kil_pi_an = kilp1.transform.GetComponent<Animator>();
		kil_pi_an2 = kilp2.transform.GetComponent<Animator>();
		}
		laser_bird_coll.attack_count =0;


		b.SetActive(true);

		coolup = 0;
		tm =0;
		
		home.SetActive(false);
		next.SetActive(false);
		restrt.SetActive(false);
		lvlcomp.SetActive(false);
		gmovertext.SetActive(false);

		/*gold.SetActive(false);
		silver.SetActive(false);
		bronze.SetActive(false);*/

		st1.SetActive(false);
		st2.SetActive(false);
		st3.SetActive(false);

		stdr1.SetActive(false);
		stdr2.SetActive(false);
		stdr3.SetActive(false);

		ratebox.SetActive(false);


		//timetaken.SetActive(false);

		is_close = false;

		gameover = false;
		win = false;

		BirdMovement2.kr2= false;
		BirdMovement2.kr= false;



		//an = g.transform.GetComponentInChildren<Animator>();
	}



	private void RequestInterstitial()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-1177092011471737/6567020203";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "ca-app-pub-1177092011471737/3819681402";
		#endif
		
		// Create an interstitial.
		interstitial = new InterstitialAd(adUnitId);
		// Register for ad events.
		/*interstitial.AdLoaded += HandleInterstitialLoaded;
		interstitial.AdFailedToLoad += HandleInterstitialFailedToLoad;
		interstitial.AdOpened += HandleInterstitialOpened;
		interstitial.AdClosing += HandleInterstitialClosing;
		interstitial.AdClosed += HandleInterstitialClosed;
		interstitial.AdLeftApplication += HandleInterstitialLeftApplication;*/
		// Load an interstitial ad.
		interstitial.LoadAd(createAdRequest());
	}



	private AdRequest createAdRequest()
	{
		return new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)
				.AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
				.AddKeyword("game")
				.SetGender(Gender.Unknown)
				.SetBirthday(new DateTime(1985, 1, 1))
				.TagForChildDirectedTreatment(false)
				.AddExtra("color_bg", "9B30FF")
				.Build();
		
	}

	// Update is called once per frame
	void Update () {
	
		if(button_play.pl_clicked)
		{
			/*audio.clip = bg;
			audio.loop = true;

			audio.Play ();*/

			//bgas.Play();

			playbgmusic(_isstop);


		}


		if(BirdMovement2.cubecoll)
		{
			b.gameObject.SetActive(false);
			anim.SetTrigger("isclose");
			is_close =true;
			gameover = true;
			//Debug.Log("Done");
		}

		if(!win)
		{
		tm+= Time.deltaTime;
		}

		Vector3 pos = transform.position;

		if(BirdMovement2.r)
		{
			//Debug.Log("mons_move");
			if(Application.loadedLevelName == "4" ||Application.loadedLevelName == "6" || Application.loadedLevelName == "12" || Application.loadedLevelName == "13" )
			{
				//pos.x +=0.17f;
				pos.x +=0.17f;
			}

			else if(Application.loadedLevelName == "14")
			{

				//pos.x +=0.24f;
				pos.x +=0.24f;
			}
			else{
		    //pos.x +=0.32f;
				pos.x +=0.22f;
			}
			BirdMovement2.r = false;

		}

		if(BirdMovement2.l == true)
		{
			anim.SetTrigger("attacked");

		}




		if(BirdMovement2.kr2 == true)
		{
			//anim.SetTrigger("attacked");
			b.gameObject.SetActive(false);
			kilp2.SetActive(true);
			kil_pi_an2.SetTrigger("pipe_kil2_tr");
			is_close =true;
			gameover = true;

			playgmovmusic(false);
			
		}


		if(BirdMovement2.kr == true)
		{
			b.gameObject.SetActive(false);
			kilp1.SetActive(true);
			kil_pi_an.SetTrigger("pipe_kil2_tr");

			is_close =true;
			gameover = true;

			playgmovmusic(false);




			//anim.SetTrigger("isclose");
			//an.SetTrigger("light");
			//is_close =true;
			//gameover = true;
			
		}

		//Debug.Log (Mathf.Abs(transform.position.x -BirdMovement2.b_pos));

		if(Application.loadedLevelName =="2" || Application.loadedLevelName =="1")
		{
			if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)>=3.30f)
			{
				b.gameObject.SetActive(false);
				anim.SetTrigger("isclose");
				//an.SetTrigger("light");
				is_close =true;
				gameover = true;


				

			}

		}

		else if( Application.loadedLevelName =="7" ){

			if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)<=1.00f)
			{
				b.gameObject.SetActive(false);
				anim.SetTrigger("isclose");
				is_close =true;
				gameover = true;
				//Debug.Log("Done");


			}


		}


		else if( Application.loadedLevelName =="14"){
			
			if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)<=2.90f)
			{
				b.gameObject.SetActive(false);
				anim.SetTrigger("isclose");
				is_close =true;
				gameover = true;
				//Debug.Log("Done");

			
			}
			
			
		}

		else if( Application.loadedLevelName =="9" || Application.loadedLevelName =="5"  ){
			
			if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)<=2.00f)
			{
				b.gameObject.SetActive(false);
				anim.SetTrigger("isclose");
				is_close =true;
				gameover = true;
				//Debug.Log("Done");

			}
			
			
		}

		else if( Application.loadedLevelName =="4" || Application.loadedLevelName == "6" || Application.loadedLevelName == "12" || Application.loadedLevelName == "13"){
			
			if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)<=2.00f)
			{
				b.gameObject.SetActive(false); 
				anim.SetTrigger("isclose");
				is_close =true;
				gameover = true;
				//Debug.Log("Done");


			}
			
			
		}

		else {
			
			if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)<=1.00f)
			{
				b.gameObject.SetActive(false);
				anim.SetTrigger("isclose");
				is_close = true;
				gameover = true;


				
				
			}
			
			
		}

		if(is_close == true)

		{

			/*isstop =true;
			playbgmusic(_isstop);*/

			//bannerView.Show();


				GameObject soundObject = GameObject.Find("bgloop");

		
			if(GameObject.Find("bgloop"))
			{
				
				AudioSource audioSource = soundObject.GetComponent<AudioSource>();
				
				audioSource.Stop();

			}
				
				//bgstop_count++;
			//if (c%4 ==3 && interstitial.IsLoaded() && (!(win && levelno%2 == 0 && (!PlayerPrefs.HasKey("rate")))))
			if (c%4 ==3 && interstitial.IsLoaded())
			{
				interstitial.Show();
			}
				

			playgmovmusic(false);


			//coolup += Time.deltaTime;
		}

		/*if(coolup>=1.0f)
		{
			//Application.LoadLevel("gameover");

			timetaken.SetActive(true);

			home.SetActive(true);
			//next.SetActive(true);
			restrt.SetActive(true);

			if(win)
			{
			lvlcomp.SetActive(true);
			}

			else if(gameover)
			{
				gmovertext.SetActive(true);
			}

		}

		/*if(Mathf.Abs(transform.position.x -BirdMovement2.b_pos)>=9.30f)
		{
			
			anim.SetTrigger("isclose");
			is_close =true;
			
			
		}*/

		if(laser_bird_coll.attack_count>=5)
			
		{
			win = true;
			//Debug.Log("mon_death");
			anim.SetTrigger("mondeath");
			//laser_bird_coll.attack_count =0;
			PlayerPrefs.SetInt((level_number+1).ToString(), 1);
			//PlayerPrefs.SetInt((level_number+1).ToString()+"_" +(level_number+1).ToString(),1);
			button_play.pl_clicked = false;
			//Application.LoadLevel((level_number+1).ToString());

			home.SetActive(true);
			next.SetActive(true);
			restrt.SetActive(true);

			if(bgstop_count == 0)
			{
			GameObject soundObject = GameObject.Find("bgloop");
			
			AudioSource audioSource = soundObject.GetComponent<AudioSource>();
			
			audioSource.Stop();

				bgstop_count++;

				}

			if(tada_count ==0)
			{
			AudioSource.PlayClipAtPoint(tada,transform.position);
				tada_count++;

			}

			if (c%4 == 3 && interstitial.IsLoaded())
			{
				interstitial.Show();
			}

		}


		if(is_close == true || win)
			
		{
			
			coolup += Time.deltaTime;
		}
		
		if(coolup>=3.5f)
		{
			//Application.LoadLevel("gameover");
			
			//timetaken.SetActive(true);
			
			home.SetActive(true);
			//next.SetActive(true);
			restrt.SetActive(true);
			
			if(win)
			{

				//bannerView.Show();
				bool rated = PlayerPrefs.HasKey("rate");

				Debug.Log (levelno);

				//ratebox.SetActive(true);
				if(levelno%2 == 0 && (!rated))
				{
					Debug.Log ("ggggggggggggggggggg");

					ratebox.SetActive(true);

					if(Input.GetMouseButtonDown(0))
					{
						RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

						if(hit.collider.tag == "rate")
						{
							PlayerPrefs.SetInt("rate",1);
							ratebox.SetActive(false);
							Application.OpenURL ("market://details?id=" + package_name);

						}

					}

				}


				/*Social.ReportScore(500, "CgkI9fGosdcJEAIQBg", (bool success) => {
					// handle success or failure
				});*/


				if(Application.loadedLevelName == "1")
				{
					Social.ReportProgress("CgkI9fGosdcJEAIQAQ", 100.0f, (bool success) => {
						// handle success or failure
					});
				}


				lvlcomp.SetActive(true);


				if(ting_count ==0)
				{
					AudioSource.PlayClipAtPoint(ting,transform.position);
					ting_count++;
					
				}

				if(((int)tm)<=28)
				{

					//gold.SetActive(true);

					st1.SetActive(true);
					st2.SetActive(true);
					st3.SetActive(true);

					stdr1.SetActive(false);
					stdr2.SetActive(false);
					stdr3.SetActive(false);
				}

				else if(((int)tm) >28 &&  ((int)tm) <= 35)

				{

					//silver.SetActive(true);
					st1.SetActive(true);
					st2.SetActive(true);


					stdr3.SetActive(true);

				}

				else
				{
					//bronze.SetActive(true);
					st1.SetActive(true);				

				stdr2.SetActive(true);
				stdr3.SetActive(true);

				}
			}
			
			else if(gameover)
			{
				gmovertext.SetActive(true);
			}
			
		}


		if(ScorePoint_2.mons_sp_down ==5)

		{
			pos.x -=0.35f;
			ScorePoint_2.mons_sp_down =0;

		}


		transform.position = pos;

		/*if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			
			
			if((gameover || win) && hit.collider.tag =="home")
			{
				//gameover = false;
				//win = false;
				Application.LoadLevel("level_select");
			}

			else if((gameover || win) && hit.collider.tag =="restart")
			{
				//gameover = false;
				//win = false;
				Application.LoadLevel(Application.loadedLevelName);
			}

			else if(win && hit.collider.tag =="next")
			{
				//win = false;
				Application.LoadLevel((level_number+1).ToString());
			}
			
		}*/
	

	}
	void OnCollisionEnter2D(Collision2D collision) {

		//Debug.Log("dfghjkdfghjdfghjfghjfdghjfghjfghfg");
		BirdMovement2.l = false;

		
	}

}
