using UnityEngine;
using System.Collections;

public class pipe_alpha : MonoBehaviour {

	GameObject g;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		/*if(monst_movem.gameover || monst_movem.win)
		{
			g.renderer.material.color.a = 0.5f;
		}*/


		if(monst_movem.coolup >= 3.0f)
		{
			this.gameObject.SetActive(false);
		}


	}
}
