using UnityEngine;
using System.Collections;

public class levels : MonoBehaviour {


	//public Sprite [] s;
	public int _i;

	public GameObject[] g;

	public int j, garr;

	public int[] lev;
	// Use this for initialization
	void Start () {
	
		if(Application.loadedLevelName == "level_select")
		{
			j=0;

		}

		else if(Application.loadedLevelName == "level_2")
		        {

			j=9;

		}


		PlayerPrefs.SetInt("1",1);

		if(PlayerPrefs.HasKey("9"))
		     {
			PlayerPrefs.SetInt("10",1);
		     }


		for(int i =0, t = j; i<g.Length; i++,j++)
		{

			_i = i;

			if(PlayerPrefs.HasKey((j+1).ToString()))
			{
				g[i].transform.FindChild("lock").gameObject.SetActive(false);
				g[i].transform.FindChild("unlock").gameObject.SetActive(true);
				//g[i].transform.FindChild("unlock").gameObject.SetActive(true);
				//g[i].transform.FindChild("unlock").gameObject.transform.FindChild("clony_bird_sprites_1").gameObject.GetComponent<BoxCollider2D>().enabled = true;
				//SetAllCollidersStatus (true);
			}

			else{

				g[i].transform.FindChild("lock").gameObject.SetActive(true);
				g[i].transform.FindChild("unlock").gameObject.SetActive(false);
				//g[i].transform.FindChild("unlock").gameObject.transform.FindChild("clony_bird_sprites_1").gameObject.collider2D.enabled  = false;
				//g[i].transform.FindChild("unlock").gameObject.SetActive(false);
				//g[i].transform.FindChild("unlock").gameObject.transform.FindChild("clony_bird_sprites_1").gameObject.GetComponent<BoxCollider2D>().enabled = false;
				//SetAllCollidersStatus (false);
			}


		}


		/*using (AndroidJavaClass javaClass = new AndroidJavaClass("com.example.notiunity.MainActivity"))
		{
			using (AndroidJavaObject activity = javaClass.GetStatic<AndroidJavaObject>("ctx"))
			{
				activity.Call("startOne");
			}
		}*/

	}

	public void SetAllCollidersStatus (bool active) {
		foreach(BoxCollider2D c in g[_i].transform.FindChild("unlock").gameObject.transform.FindChild("clony_bird_sprites_1").gameObject.GetComponents<BoxCollider2D> ()) {
			c.enabled = active;
		}
	}
	
	// Update is called once per frame
	void Update () {
	


		/*for(int i =0;i<g.Length;i++)
		{
			if(PlayerPrefs.HasKey((i+1).ToString()))
			{
				g[i].transform.FindChild("lock").gameObject.SetActive(false);
				g[i].transform.FindChild("unlock").gameObject.SetActive(true);
			}
			
			else{
				
				g[i].transform.FindChild("lock").gameObject.SetActive(true);
				g[i].transform.FindChild("unlock").gameObject.SetActive(false);
			}
			
			
		}*/

		/*for(int i =0;i<g.Length;i++)
		{
			if(PlayerPrefs.HasKey((i+1).ToString()))
			{
				g[i].transform.FindChild("lock").gameObject.SetActive(false);
				g[i].transform.FindChild("unlock").gameObject.SetActive(true);
			}
			
			else{
				
				g[i].transform.FindChild("lock").gameObject.SetActive(true);
				g[i].transform.FindChild("unlock").gameObject.SetActive(false);
			}
			
			
		}*/

		if(Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel("start 1");
		}


		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			Debug.Log("===="+hit.collider.name.ToString());
			if(hit.collider.tag!="Untagged")
			{
				if(hit.collider.tag == "1")
				{
					Application.LoadLevel( "help 1" );
				}
			
				else 
				{
				//Debug.Log("===="+hit.collider.tag.ToString());

					if(hit.collider.tag !="for1" && hit.collider.tag != "b1")
					{
				Application.LoadLevel( hit.collider.tag.ToString() );
					}
				}

				if(Application.loadedLevelName == "level_select")
				{
				if(hit.collider.tag == "for1")
				{
					
					Application.LoadLevel("level_2");
				}
				
			}
			
			if(Application.loadedLevelName == "level_2"){
				
				if(hit.collider.tag == "b1")
				{
					
					Application.LoadLevel("level_select");
				}
				
			}
			
			}


	}
}
}