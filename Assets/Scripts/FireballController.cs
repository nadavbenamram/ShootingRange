using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : MonoBehaviour
{
	GameObject m_FireBallPrefab;
	// Use this for initialization
	void Start ()
	{
		m_FireBallPrefab = Resources.Load ("FireBall") as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GvrPointerInputModule.Pointer.TriggerDown) 
		{
			GameObject fireBall = Instantiate(m_FireBallPrefab, this.transform.position + new Vector3(0, 1), this.transform.rotation) as GameObject;
			Rigidbody rigidbody = fireBall.GetComponent<Rigidbody> ();
			rigidbody.velocity = this.transform.forward * 30;
		}
	}
}
