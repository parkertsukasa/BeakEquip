using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	public Touch touch;

	void Awake()
	{
		touch = GetComponent<Touch> ();
	}

	// Use this for initialization
	void Start () 
	{
		//touch = Resources.Load ("Touch") as Touch;
	}
	
	// Update is called once per frame
	void Update () 
	{
		string swipe = "null";
		swipe = touch.Swipe ();
		Debug.Log (swipe);
	}
}
