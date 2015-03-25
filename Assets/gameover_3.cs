using UnityEngine;
using System.Collections;
//using VservPlugin;
using GoogleMobileAds;
using System;
using GoogleMobileAds.Api;


public class gameover_3 : MonoBehaviour {

	private int adId = -1;
	public bool isfilled;
	public Rect bound;

	private BannerView bannerView;
	
	//private VservWP8Plugin vservPlugin = new VservWP8Plugin ();
	// Use this for initialization
	void Start () {
	
		/*vservPlugin.VservAdNoFill += HandleNoFill;
		//vservPlugin.SetTestMode(true);

		adId = vservPlugin.RenderAd ("d6dd12c0", 1);

		isfilled = true;

		bound = new Rect(-6.653267f,1.872577f,Mathf.Abs(5.215834f -(-6.653267f)),Mathf.Abs(1.872577f -(-3.178977f)));

		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-1177092011471737/2342948200";
		#else
		string adUnitId = "unexpected_platform";
		#endif



		bannerView.LoadAd(createAdRequest());*/


		//adId = vservPlugin.RenderAd ("d6dd12c0", 1);
		RequestBanner();

	}


	private void RequestBanner()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-1177092011471737/2342948200";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "ca-app-pub-1177092011471737/2342948200";
		#endif
		
		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top);
		// Register for ad events.
		bannerView.AdLoaded += HandleAdLoaded;
		bannerView.AdFailedToLoad += HandleAdFailedToLoad;
		bannerView.AdOpened += HandleAdOpened;
		bannerView.AdClosing += HandleAdClosing;
		bannerView.AdClosed += HandleAdClosed;
		bannerView.AdLeftApplication += HandleAdLeftApplication;
		// Load a banner ad.
		bannerView.LoadAd(createAdRequest());
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

	/*void HandleNoFill (object sender, System.EventArgs e)
	{
		isfilled = false;
		vservPlugin.HideBanner(adId);
	}*/
	
	// Update is called once per frame
	void Update () {
	


		/*if (Input.GetMouseButtonDown(0))
		{
			//Creating container for the raycast result
			RaycastHit2D hitInfo = new RaycastHit2D();
			//Making the raycast
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
			{
				//Assuming animation is how you are rotating the cube
				if(hitInfo.collider.tag == "gameoverbox")
				{
					Debug.Log("Done");
				}
			}
		}*/

		if(Input.GetMouseButtonDown(0))
		{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		
		if(hit.collider.tag =="gameoverbox")
		{
			//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);

				Application.LoadLevel( "scene_2" );
				//vservPlugin.HideBanner(adId);

			//Debug.Log("yesss");
		}
		}



		if(Input.GetKeyDown(KeyCode.Space) || bound.Contains(Input.mousePosition))
		{
			/*Application.LoadLevel( "scene_1" );
			vservPlugin.HideBanner(adId);*/

			//Debug.Log("Done");
		}


		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel( "scene_1" );
			//vservPlugin.HideBanner(adId);
		}

		/*if(isfilled == true)
		{
			vservPlugin.RenderAd ("20846", 8);
		}*/



	}

	#region Banner callback handlers
	
	public void HandleAdLoaded(object sender, EventArgs args)
	{
		print("HandleAdLoaded event received.");
	}
	
	public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
		print("HandleFailedToReceiveAd event received with message: " + args.Message);
	}
	
	public void HandleAdOpened(object sender, EventArgs args)
	{
		print("HandleAdOpened event received");
	}
	
	void HandleAdClosing(object sender, EventArgs args)
	{
		print("HandleAdClosing event received");
	}
	
	public void HandleAdClosed(object sender, EventArgs args)
	{
		print("HandleAdClosed event received");
	}
	
	public void HandleAdLeftApplication(object sender, EventArgs args)
	{
		print("HandleAdLeftApplication event received");
	}
	
	#endregion


}
