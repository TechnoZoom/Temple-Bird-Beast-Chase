﻿using UnityEngine;
using System.Collections;

public class help1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			


				if(hit.collider.tag == "mm2")
				{
					
					Application.LoadLevel( "1" );
					
				}

			
		}


	}
}
