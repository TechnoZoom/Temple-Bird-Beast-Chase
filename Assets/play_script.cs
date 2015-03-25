using UnityEngine;
using System.Collections;

public class play_script : MonoBehaviour {
	GameObject bird,cam;
	// Use this for initialization
	void Start () {
	
		 bird = GameObject.FindGameObjectWithTag("Player");
		cam = GameObject.FindGameObjectWithTag("MainCamera");
		bird.SetActive(false);
		cam.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
