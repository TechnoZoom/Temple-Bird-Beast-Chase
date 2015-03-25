using UnityEngine;
using System.Collections;

public class laser_parent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		gameObject.collider2D.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(BirdMovement2.l == true)
		{
			gameObject.collider2D.enabled = true;

		}

		else{
			gameObject.collider2D.enabled = false;
		}


	}


	/*void OnCollisionEnter2D(Collision2D collision) {



			Debug.Log("dfghjkdfghjdfghjfghjfdghjfghjfghfg");
			BirdMovement2.l = false;


			


	}*/
}
