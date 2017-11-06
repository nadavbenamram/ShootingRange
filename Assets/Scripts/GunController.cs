using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZEffects;

public class GunController : MonoBehaviour {

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
			GameObject gunShot = Instantiate (m_GunShot, this.transform.position, this.transform.rotation) as GameObject;
			m_Flash.Play ();
		}

		m_LastTriggerDown = currentTrigger;
	}
}
