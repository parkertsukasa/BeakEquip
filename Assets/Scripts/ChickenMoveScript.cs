using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMoveScript : MonoBehaviour {

	private Touch touch;

	private bool go = false;


	// Use this for initialization
	void Start () 
	{
		touch = GetComponent<Touch> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		string swipe = touch.Swipe ();

		if(swipe == "right")
		{
			go = true;
			Invoke ("GoOff",1.0f);

		}

		Move ();

	}

	private void GoOff()
	{
		go = false;
	}

	private void Move ()
	{
		if (go == true)
		{
			transform.position += new Vector3 (0, 0, 5 * Time.deltaTime);
		}



	}

}
