using UnityEngine;
using System.Collections;
using VservPlugin;


public class pause : MonoBehaviour {

	Transform pre,cur;

	static pause instance;

	private VservWP8Plugin vservPlugin = new VservWP8Plugin ();
	BirdMovement2 br;
	static public bool ad_avil;

	private int adId = -1;

	private string eventString = "No Events";
	// Use this for initialization
	void Start () {
	
	
		/*ad_avil = false;
		/*vservPlugin.VservAdClosed += HandleAdClosed;
		vservPlugin.VservAdError += HandleAdError;
		/*vservPlugin.VservAdNoFill += HandleNoFill;
		vservPlugin.SetTestMode (true);
		vservPlugin.SetRefreshRate (40);
		vservPlugin.SetRequestTimeOut (30);*/

		//instance = this;
		//GetComponent<SpriteRenderer>().enabled=false;
		//GameObject cur_go = GameObject.FindGameObjectWithTag("menu");
		//GameObject pre_go = GameObject.FindGameObjectWithTag("premenu");

		//GameObject pl = GameObject.FindGameObjectWithTag("Player");
		//br = pl.GetComponent<BirdMovement2>();

		//pre = pre_go.transform;
		//cur = cur_go.transform;

		//transform.position = pre.position;
	}

	/*void HandleNoFill (object sender, System.EventArgs e)
	{
		eventString = "HandleNoFill";

	}
	
	void HandleAdError (object sender, System.EventArgs e)
	{
		eventString = "HandleAdError";
	}
	
	void HandleAdClosed (object sender, System.EventArgs e)
	{
		eventString = "HandleAdClosed";
	}*/

	
	// Update is called once per frame
	void Update () {
	
		/*if(instance.br.dead && rate.has_rated==1 && BirdMovement2.deathCooldown <=0)
		{
			ad_avil = true;
			GetComponent<SpriteRenderer>().enabled = true;
			//vservPlugin.DisplayAd("8063");

			/*if(ad_avil)
			{
				adId = vservPlugin.RenderAd ("20846", 8);
				//vservPlugin.ShowBanner(adId);
			}*/
		//}

	}
}
