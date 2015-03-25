using UnityEngine;
using System.Collections;

public class ScorePoint_2 : MonoBehaviour {

	static public  int _score =0;
	static public int highScore =0;

	static ScorePoint_2 instance;
	BirdMovement2 br;
	public static int mons_sp_down;

	 public AudioClip coin;

	void Start()
	{
		/*_score=0;
		instance = this;


		
		GameObject pl = GameObject.FindGameObjectWithTag("Player");
		br = pl.GetComponent<BirdMovement2>();
		
		highScore = PlayerPrefs.GetInt("highscore",0);*/
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		/*if(collider.tag =="Player");
		{
			Debug.Log("chbjbjhbhjbh");
			
			//score_2.Addpoint();

			if(instance.br.dead== false)
			{
				_score++;

				mons_sp_down++;



		

				AudioSource.PlayClipAtPoint(coin,transform.position);

				if(_score > highScore)
				{
					highScore= _score;
				}
			}
		}*/

	}

	void OnDestroy()
	{
		/*instance = null;
		PlayerPrefs.SetInt("highscore",highScore);*/
	}

}


			
			//gameObject.SetActive(false);
		
		
	
