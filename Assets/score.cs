using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {


	static public  int _score =0;
	 static public int highScore =0;
	// Use this for initialization
	void Start () {
	

	}

	static public void Addpoint()
	{
		_score++;
		if(_score > highScore)
		{
			highScore= _score;
		}


	}
	
	// Update is called once per frame
	void Update () {
	

		guiText.text ="Score: "+_score+"\nHigh Score : "+highScore;
	}
}
