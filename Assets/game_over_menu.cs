using UnityEngine;
using System.Collections;

using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class game_over_menu : MonoBehaviour {

	GameObject bird;

	BannerView bannerView;
	// Use this for initialization
	void Start () {
	

		bird = GameObject.FindGameObjectWithTag("Player");
		/*bannerView = new BannerView(
			"ca-app-pub-1177092011471737/5766757009", AdSize.Banner, AdPosition.Bottom);
		
		
		bannerView.LoadAd(createAdRequest());*/
		


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
	

		/*if(monst_movem.win || monst_movem.is_close)

		{
			bannerView.Show();

		}

		else{

			bannerView.Hide();

		}*/

		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			//monst_movem.tm =0;
			
			if(hit.collider.tag =="home")
			{
				monst_movem.gameover = false;
				monst_movem.win = false;
				//bird.SetActive(true);
				//bannerView.Destroy();

				monst_movem.win = false;
				monst_movem.is_close = false;

				bannerView.Hide();

				//Application.LoadLevel("level_select");

				if(PlayerPrefs.HasKey ("9"))
				{
					Application.LoadLevel( "level_2" );
				}
				
				else
				{
					Application.LoadLevel( "level_select" );
				}

			}
			
			else if(hit.collider.tag =="restart")
			{
				monst_movem.gameover = false;
				monst_movem.win = false;
				//bird.SetActive(true);
				//Application.LoadLevel(Application.loadedLevelName);

				monst_movem.win = false;
				monst_movem.is_close = false;

				bannerView.Hide();
				//bannerView.Destroy();

				//Andrating.openmarket();

				//Application.OpenURL ("market://details?id=com.bsb.games.jellies");



				Application.LoadLevel(Application.loadedLevel);

			}
			
			else if(hit.collider.tag =="next")
			{
				monst_movem.win = false;
				//bannerView.Destroy();

				monst_movem.win = false;
				monst_movem.is_close = false;

				bannerView.Hide();

				Application.LoadLevel((monst_movem.level_number+1).ToString());
			}


		}
		
		
	}

	}

