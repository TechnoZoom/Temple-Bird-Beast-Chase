using UnityEngine;
using System.Collections;



using System;


public class button_play : MonoBehaviour {


	GameObject bird,cam;

	public static bool pl_clicked;
	// Use this for initialization
	void Start () {
		 bird = GameObject.FindGameObjectWithTag("Player");
		cam = GameObject.FindGameObjectWithTag("MainCamera");
		pl_clicked = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);



			if(hit.collider.tag =="pl")
			{
				//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);

				/*bird.SetActive(true);
				cam.SetActive(true);*/

				Debug.Log("playy pressed");

				pl_clicked = true;
				this.gameObject.SetActive(false);
				//this.gameObject.SetActive(false);

				//vservPlugin.HideBanner(adId);
				
				//Debug.Log("yesss");
			}

	}
}
}