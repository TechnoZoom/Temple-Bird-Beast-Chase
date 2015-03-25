using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

		gameObject.renderer.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(BirdMovement2.l== true)
		{
			gameObject.renderer.enabled = true;

		}

		else

		{
			gameObject.renderer.enabled = false;
		}

	}
}
