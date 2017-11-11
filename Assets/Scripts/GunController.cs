using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	private const int LINE_LENGTH = 100;
	public GameObject m_GunShot;
	public ParticleSystem m_Flash;
	// Use this for initialization
	void Start () 
	{
	}

	private bool m_LastTriggerDown = false;
	void Update() {
		bool currentTrigger = GvrPointerInputModule.Pointer.TriggerDown;
		if (true == currentTrigger && false == m_LastTriggerDown) {
			GameObject gunShot = Instantiate (m_GunShot, this.transform.position, m_GunShot.transform.rotation) as GameObject;
			m_Flash.Play ();
			Rigidbody rigidbody = gunShot.GetComponent<Rigidbody> ();
			rigidbody.velocity = this.transform.forward * 50;
		}

	}
}
