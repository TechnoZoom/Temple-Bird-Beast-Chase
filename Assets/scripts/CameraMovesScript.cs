using UnityEngine;
using System.Collections;

public class CameraMovesScript : MonoBehaviour {

	
	Transform player;
	
	float offsetX;

	string level_name;

	public static bool pau;

	GameObject player_go,play_button,home,restrt,next;


	
	// Use this for initialization
	void Start () {
		 player_go = GameObject.FindGameObjectWithTag("Player");

		play_button = GameObject.FindGameObjectWithTag("pl");

		/*home = GameObject.FindGameObjectWithTag("home");

		restrt = GameObject.FindGameObjectWithTag("restart");

		next = GameObject.FindGameObjectWithTag("next");

		home.SetActive(false);
		next.SetActive(false);
		restrt.SetActive(false);*/

		level_name = Application.loadedLevelName;

		//player_go.SetActive(false);

		/*if(player_go == null) {
			Debug.LogError("Couldn't find an object with tag 'Player'!");
			return;
		}*/
	

		player = player_go.transform;
		
		offsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		/*if(button_play.pl_clicked == true)
		{
			player_go.SetActive(true);
			play_button.SetActive(false);


		}*/

		if(player != null) {

			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetX;
			transform.position = pos;

			/*if (Input.GetKey(KeyCode.Escape)) 
			{
				

					pau = true;
					//gb_bg.an.SetTrigger("gmover");

					

					

			
			}*/

		}

		/*if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(Application.loadedLevelName == "help")
			{

			if(hit.collider.tag == "mm")
			{

				Application.LoadLevel( "start 1" );

			}
			}


			if(Application.loadedLevelName == "help 1")
			{
			if(hit.collider.tag == "mm2")
			{
				
				Application.LoadLevel( "1" );
				
			}
			}

		}*/
	



		/*if (Input.GetKey(KeyCode.Escape)) 
		{
			
			Application.LoadLevel( "start 1" );
			
		}*/


	}
}