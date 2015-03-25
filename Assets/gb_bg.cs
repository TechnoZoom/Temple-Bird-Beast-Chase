using UnityEngine;
using System.Collections;

public class gb_bg : MonoBehaviour {

	public static Animator an;

	public GameObject pauplay,home,restrt;

	// Use this for initialization
	void Start () {
	
		an = transform.GetComponent<Animator>();
		pauplay = GameObject.FindGameObjectWithTag("pauplay");

		home = GameObject.FindGameObjectWithTag("home");
		
		restrt = GameObject.FindGameObjectWithTag("restart");

		//Time.timeScale = 1

		if(Time.timeScale == 0)
			
		{
			Time.timeScale = 1;
			
		}

		/*Vector3 bgsize = transform.localScale;
		bgsize.x = Screen.width;
		bgsize.y = Screen.height;

		transform.localScale = bgsize;*/

		pauplay.SetActive(false);




	}
	

	// Update is called once per frame
	void Update () {
	
		if(monst_movem.is_close == true || monst_movem.win)

		{
			an.SetTrigger("gmover");
		}

		if (Input.GetKey(KeyCode.Escape) && button_play.pl_clicked) 

		{
			an.SetTrigger("gmover");

			pauplay.SetActive(true);
			home.SetActive(true);
			restrt.SetActive(true);

			if(Time.timeScale > 0 )
			
			{
				Time.timeScale = 0;

			}

		}

		if(Input.GetMouseButtonDown(0) && Time.timeScale == 0)
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

		if(hit.collider.tag =="pauplay" )

		{

		if(Time.timeScale == 0)
			
		{
			Time.timeScale = 1;
			
		}

			pauplay.SetActive(false);
				home.SetActive(false);
				restrt.SetActive(false);
				an.SetTrigger("pau");

		}

		}




	}

	public static void bganim()
	{
		an.SetTrigger("gmover");
	}
}
