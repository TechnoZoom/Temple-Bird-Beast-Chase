using UnityEngine;
using System.Collections;
//using VservPlugin;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;

public class gameover_2 : MonoBehaviour {

	//private VservWP8Plugin vservPlugin = new VservWP8Plugin ();

	private InterstitialAd interstitial;

	// Use this for initialization
	void Start () {
	
		/*vservPlugin.VservAdClosed += HandleAdClosed;
		vservPlugin.VservAdError += HandleAdError;
		vservPlugin.VservAdNoFill += HandleNoFill;*/

		PlayerPrefs.SetInt("gameoveronce",1);

		//vservPlugin.SetTestMode(true);

		//vservPlugin.DisplayAd("4fd4437a");


		/*#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-1177092011471737/3819681402";
		#else
		string adUnitId = "unexpected_platform";
		#endif


		interstitial = new InterstitialAd(adUnitId);
		interstitial.AdFailedToLoad += HandleInterstitialFailedToLoad;
		interstitial.AdClosed += HandleInterstitialClosed;



		interstitial.LoadAd(createAdRequest());

		if (interstitial.IsLoaded())
		{
			interstitial.Show();
		}*/




		/*string adUnitId = "ca-app-pub-1177092011471737/3819681402";

		interstitial = new InterstitialAd(adUnitId);
		interstitial.AdFailedToLoad += HandleInterstitialFailedToLoad;
		interstitial.AdClosed += HandleInterstitialClosed;
		
		
		
		interstitial.LoadAd(createAdRequest());
		
		if (interstitial.IsLoaded())
		{
			interstitial.Show();
		}*/

		//Time.timeScale = 0;

		RequestInterstitial();

		
	}


	/*void HandleNoFill (object sender, System.EventArgs e)
	{
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}
	}*/


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

	private void RequestInterstitial()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-1177092011471737/3819681402";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "ca-app-pub-1177092011471737/3819681402";
		#endif
		
		// Create an interstitial.
		interstitial = new InterstitialAd(adUnitId);
		// Register for ad events.
		interstitial.AdLoaded += HandleInterstitialLoaded;
		interstitial.AdFailedToLoad += HandleInterstitialFailedToLoad;
		interstitial.AdOpened += HandleInterstitialOpened;
		interstitial.AdClosing += HandleInterstitialClosing;
		interstitial.AdClosed += HandleInterstitialClosed;
		interstitial.AdLeftApplication += HandleInterstitialLeftApplication;
		// Load an interstitial ad.
		interstitial.LoadAd(createAdRequest());
	}


	/*void HandleAdError (object sender, System.EventArgs e)
	{
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}
	}*/

	/*void HandleAdClosed (object sender, System.EventArgs e)
	{
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}
	}*/

	/*public void HandleInterstitialClosed(object sender, EventArgs args)
	{
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}
	}

	public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}
	}*/


	private void ShowInterstitial()
	{
		if (interstitial.IsLoaded())
		{
			interstitial.Show();
		}
		else
		{
			print("Interstitial is not ready yet.");
		}
	}


	#region Interstitial callback handlers
	
	public void HandleInterstitialLoaded(object sender, EventArgs args)
	{
		print("HandleInterstitialLoaded event received.");
	}
	
	public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
		//print("HandleInterstitialFailedToLoad event received with message: " + args.Message);
		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}

	}
	
	public void HandleInterstitialOpened(object sender, EventArgs args)
	{
		print("HandleInterstitialOpened event received");
	}
	
	void HandleInterstitialClosing(object sender, EventArgs args)
	{
		print("HandleInterstitialClosing event received");
	}
	
	public void HandleInterstitialClosed(object sender, EventArgs args)
	{
		//print("HandleInterstitialClosed event received");

		interstitial.Destroy();

		if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
		{
			Application.LoadLevel( "gameover 5" );
		}
		
		else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
		{
			Application.LoadLevel( "gameover 6" );
		}
		
		else if(ScorePoint_2._score >24)
		{
			Application.LoadLevel( "gameover 7" );
		}
		
		else {
			Application.LoadLevel( "gameover 8" );
		}
	}
	
	public void HandleInterstitialLeftApplication(object sender, EventArgs args)
	{
		print("HandleInterstitialLeftApplication event received");
	}
	
	#endregion

	
	// Update is called once per frame
	void Update () {
	

		ShowInterstitial();

		/*if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel( "scene_1" );

		}*/

		/*if (Input.GetKey(KeyCode.Escape)) 
		{

			if(ScorePoint_2._score >= 10 && ScorePoint_2._score < 20)
			{
				Application.LoadLevel( "gameover 5" );
			}
			
			else if(ScorePoint_2._score >= 20 && ScorePoint_2._score < 25)
			{
				Application.LoadLevel( "gameover 6" );
			}
			
			else if(ScorePoint_2._score >24)
			{
				Application.LoadLevel( "gameover 7" );
			}
			
			else {
				Application.LoadLevel( "gameover 8" );
			}


		}*/



	}
}
