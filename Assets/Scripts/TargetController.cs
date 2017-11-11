using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {
	private bool m_IsHitted = false;
	public GameObject m_TargetMesh;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (true == m_IsHitted) {
			//rotate
		}
	}

	public void TargetHit()
	{
		m_IsHitted = true;
		Debug.Log ("target " + this.gameObject.name + " hitted");
		//Destroy (m_TargetMesh);
	}
}
