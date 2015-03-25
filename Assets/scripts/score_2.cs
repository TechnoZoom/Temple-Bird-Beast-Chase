using UnityEngine;
using System.Collections;

public class score_2 : MonoBehaviour {

	// Use this for initialization
	static public  int _score =0;
	static public int highScore =0;
	// Use this for initialization

	static score_2 instance;
	BirdMovement2 br;
	
	static public void Addpoint()
	{
		if(instance.br.dead)
		{
			return;
		}
	
		_score++;
		if(_score > highScore)
		{
			highScore= _score;
		}
		
		
	}

	void Start()
	{
		guiText.enabled = false;
		_score=0;
		instance = this;

		GameObject pl = GameObject.FindGameObjectWithTag("Player");
		br = pl.GetComponent<BirdMovement2>();

		highScore = PlayerPrefs.GetInt("highscore",0);
	}


	void OnDestroy()
	{
		instance = null;
		PlayerPrefs.SetInt("highscore",highScore);
	}
	
	// Update is called once per frame
	void Update () {
		if(instance.br.dead && rate.has_rated==1){
			guiText.enabled = true;
			guiText.text ="Score: "+ScorePoint_2._score+"\nHigh Score : "+ScorePoint_2.highScore;

		}


		else{
			guiText.enabled = false;
		}

	}
}
