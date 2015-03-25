using UnityEngine;
using System.Collections;

public class intialstart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel("scene_1");
		}

		if (Input.GetKey(KeyCode.Escape)) 
		{
			
			Application.LoadLevel("start");
			/*if (isInMenu) 
			{
				ToggleMenu(); 
			}
			else {
				Application.Quit();
			} */
			
		}
	}
}
