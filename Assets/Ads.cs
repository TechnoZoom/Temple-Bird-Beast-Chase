using UnityEngine;
using System.Collections;
using VservPlugin;

public class Ads : MonoBehaviour {


	private VservWP8Plugin vservPlugin = new VservWP8Plugin ();
	// Use this for initialization
	void Start () {
	
		vservPlugin.SetTestMode (true);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(pause.ad_avil == true)
		{
			vservPlugin.DisplayAd("8063");
		}

	}
}
