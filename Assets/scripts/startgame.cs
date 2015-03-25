using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
//using VservPlugin;

public class startgame : MonoBehaviour {
	//private VservWP8Plugin vservPlugin = new VservWP8Plugin ();

	public AudioClip start_game;
	public AudioClip tada;




	/*private static AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
	private static AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"); */
	// Use this for initialization
	void Start () {
	
		//vservPlugin.SetTestMode (true);

		//PlayerPrefs.DeleteAll();

		PlayGamesPlatform.DebugLogEnabled = true;
		// Activate the Google Play Games platform
		PlayGamesPlatform.Activate();


		Social.localUser.Authenticate((bool success) => {
			// handle success or failure
			if(success)
			{
				AudioSource.PlayClipAtPoint(tada,transform.position);
			}
		});
	}
	
	
	// Update is called once per frame
	void Update () {
	

		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit.collider.tag =="play2")
			{
				//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);

				if(PlayerPrefs.HasKey ("9"))
				    {
				Application.LoadLevel( "level_2" );
				    }

				else
				{
					Application.LoadLevel( "level_select" );
				}



				//vservPlugin.HideBanner(adId);
				
				//Debug.Log("yesss");
			}

			else if(hit.collider.tag == "help")

			{

				Application.LoadLevel( "help" );
			}

			else if(hit.collider.tag == "more")
				
			{
				
				Social.ShowLeaderboardUI();
			}

			/*else if(hit.collider.tag == "toast")
				
			{
				
				/*using (AndroidJavaClass javaClass = new AndroidJavaClass("com.example.toast.MainActivity"))
				{
					using (AndroidJavaObject activity = javaClass.GetStatic<AndroidJavaObject>("ctx"))
					{
						activity.Call("fun");
					}
				}*/
				/*jo.Call("makeToast","Toast is working");
			}*/
			else if(hit.collider.tag =="contactus")
				
			{
				
				WPcode_2._action_2();
			}

			/*else{

				return;
			}*/

		}


		/*if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) ) {
			AudioSource.PlayClipAtPoint(start_game,transform.position);
			Application.LoadLevel("scene_1" );
		}*/
			//vservPlugin.DisplayAd("8063");

		if (Input.GetKey(KeyCode.Escape)) 
		{
			
			Application.Quit();

		}
	

	}



}