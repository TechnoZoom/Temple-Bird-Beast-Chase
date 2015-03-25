using UnityEngine;
using System.Collections;

public class timetaken : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		guiText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(monst_movem.win){
			guiText.enabled = true;
			guiText.text ="Time Taken : "+((int)monst_movem.tm).ToString();
			
		}

	}
}
