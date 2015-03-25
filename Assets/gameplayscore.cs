using UnityEngine;
using System.Collections;
using VservPlugin;

public class gameplayscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		//vservPlugin.VservAdNoFill += HandleNoFill;
	}



	
	// Update is called once per frame
	void Update () {
	
		guiText.text = ScorePoint_2._score.ToString();

	}
}
