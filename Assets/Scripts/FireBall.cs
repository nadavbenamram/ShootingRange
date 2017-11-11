using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {
	private float m_TimeToDestroy = 2f;

	public void Update()
	{
		m_TimeToDestroy -= Time.deltaTime;
		if (m_TimeToDestroy <= 0) {
			GameObject.Destroy (this.gameObject);
		}
	}
}
