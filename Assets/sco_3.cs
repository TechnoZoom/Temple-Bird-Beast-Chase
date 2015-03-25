using UnityEngine;
using System.Collections;

public class sco_3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		guiText.text ="Score: "+ScorePoint_2._score+"\nHigh Score : "+ScorePoint_2.highScore;
	}
	
	// Update is called once per frame
	void Update () {
	
		/*if (Input.GetKey(KeyCode.Escape)) 
		{

			Application.LoadLevel("scene 1");
			/*if (isInMenu) 
			{
				ToggleMenu(); 
			}
			else {
				Application.Quit();
			} 

	}*/
}
}