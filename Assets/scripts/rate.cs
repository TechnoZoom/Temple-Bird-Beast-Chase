using UnityEngine;
using System.Collections;


public class rate : MonoBehaviour {

	BirdMovement2 br;






	static rate instance;
	static public int has_rated; 

	public GameObject left,right,bottom;

	public float width,height;

	//public Rect bounds = new Rect(-4.048871f, 2.42031f, 2.42046f, 1.236731f);

	public Rect bounds ;
	// Use this for initialization
	void Start () {
	
		PlayerPrefs.SetInt("ratedit",1);

		/*has_rated = PlayerPrefs.GetInt("rated",0);

		left = GameObject.FindGameObjectWithTag("left");
		instance = this;
		GetComponent<SpriteRenderer>().enabled=false;

		GameObject pl = GameObject.FindGameObjectWithTag("Player");
		br = pl.GetComponent<BirdMovement2>();*/
	}


	
	// Update is called once per frame
	void Update () {


		/*if(Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.Space))
		{
			WPcode._action();
			Application.LoadLevel("scene_1");


		}*/



		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit.collider.tag == "ratebox")
			{
				//Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);

				//Debug.Log("ratee");
				WPcode._action();
				Application.LoadLevel("scene_2");
				//vservPlugin.HideBanner(adId);
				
				//Debug.Log("yesss");
			}

		}
	
		//Debug.Log (left.transform.position.x.ToString());
		/* bounds = new Rect(0, 0, Screen.width, Screen.height);

		if(instance.br.dead && has_rated==0 && BirdMovement2.deathCooldown <=0)
		{
			left = GameObject.FindGameObjectWithTag("left");
			right = GameObject.FindGameObjectWithTag("right");
			bottom = GameObject.FindGameObjectWithTag("bottom");

			width = Mathf.Abs(right.transform.position.x - left.transform.position.x);
			height = Mathf.Abs(left.transform.position.y - bottom.transform.position.y);

			//bounds = new Rect(left.transform.position.x,left.transform.position.y,width,height);

			GetComponent<SpriteRenderer>().enabled = true;
			if (Input.GetMouseButtonDown(0) && bounds.Contains(Input.mousePosition))
			{
				Debug.Log("Left!");  
				PlayerPrefs.SetInt("rated",1);

				WPcode._action();
			}
		}*/

	}

	void OnGUI()
	{

			/*Texture2D tx2DFlash = new Texture2D(1,1); //Creates 2D texture
			tx2DFlash.SetPixel(1,1,Color.white); //Sets the 1 pixel to be white
			tx2DFlash.Apply(); //Applies all the changes made*/
		//GUI.Box(bounds,"hvjhghghj"); //Draws the texture for the entire screen (width, height)
			//StartCoroutine(SetFlashFalse());

	}

	/*void OnMouseDown() {
		Debug.Log("Sprite clickedddd!!!!");
	}*/
}
