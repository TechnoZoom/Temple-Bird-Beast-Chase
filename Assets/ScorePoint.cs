using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag =="Player" );
		{
			Debug.Log("chbjbjhbhjbh");

			score.Addpoint();

			gameObject.SetActive(false);
		}
		
	}




}
