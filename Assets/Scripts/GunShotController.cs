using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotController : MonoBehaviour 
{
	private float m_TimeToDestroy = 0.8f;

	// Update is called once per frame
	void Update () 
	{
		m_TimeToDestroy -= Time.deltaTime;
		if (m_TimeToDestroy <= 0) {
			Destroy (this.gameObject);
		}
	}
}
