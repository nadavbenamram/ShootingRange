using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GVR;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GvrControllerInput.ClickButton) {
			Debug.Log ("test123");
		}
	}

	public void GunShot()
	{
		Debug.Log ("Gun SHOOT!!!");
	}

	public void test()
	{
		Debug.Log ("Gun SHOOT!!!");
	}
}
