using UnityEngine;
using System.Collections;

public class health_mons : MonoBehaviour {

	GameObject health;
	public Vector3 length;

	public float minus_length;

	// Use this for initialization
	void Start () {
	

		//health = gameObject.GetComponent<SpriteRenderer>();

		length = transform.localScale;

		minus_length = length.x/5;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(laser_bird_coll.f)
		{
			length.x -= minus_length;
			laser_bird_coll.f = false;
		}

		transform.localScale = length;

	}
}
