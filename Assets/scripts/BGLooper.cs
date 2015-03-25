using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {
	
	int numBGPanels = 4;
	
	/*float pipeMax = 2.984992f;
	float pipeMin = 0.8124643f;*/

	float pipeMax = 2.284992f;
	float pipeMin = 0.8124643f;

	public float bg_mov;
	
	void Start() {
	GameObject[] pipes = GameObject.FindGameObjectsWithTag("pipe");
		
		foreach(GameObject pipe in pipes) {
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range(pipeMin, pipeMax);
			pipe.transform.position = pos;
		}



	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		//Debug.Log ("Triggered: " + collider.name);
		
		float widthOfBGObject = ((BoxCollider2D)collider).size.x;
		
		Vector3 pos = collider.transform.position;
		
		pos.x += widthOfBGObject * numBGPanels ;

		//pos.x += bg_mov;
		
		/*if(collider.tag == "Pipe") {
			pos.y = Random.Range(pipeMin, pipeMax);
		}*/
		
		collider.transform.position = pos;

		if(collider.tag == "pipe")
		{
			pos.y = Random.Range(pipeMin,pipeMax);
			Debug.Log("fghj");
		}

		collider.transform.position = pos;
		
	}



}
