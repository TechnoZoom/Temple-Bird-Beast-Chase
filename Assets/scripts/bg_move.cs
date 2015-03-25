using UnityEngine;
using System.Collections;

public class bg_move : MonoBehaviour {

	
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapvelocity;
	
	public float fixedhorizontalspeed;
	public float maxspeed;
	
	bool didflap = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/*void Update () {
		
		if(Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.Space))
		{
			didflap = true;
		}
		
	}*/
	
	void FixedUpdate()
	{
		//velocity.x= fixedhorizontalspeed;
		/*velocity += gravity*Time.deltaTime;
		 * 
		 * 
		
		
		
		if(didflap==true)
		{
			didflap = false;
			velocity += flapvelocity;
		}
		
		velocity = Vector3.ClampMagnitude(velocity,maxspeed);*/
		//transform.position += velocity*Time.deltaTime;
		
		/*float angle =0;
		
		if(velocity.y <0)
		{
			angle = Mathf.Lerp (0,-90,-velocity.y/maxspeed);
		}
		
		transform.rotation = Quaternion.Euler(0,0,angle);*/

		Vector3 pos = transform.position;
		pos.x += 0.05f*Time.deltaTime;
		transform.position = pos;
		
		
	}
	
}
