using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour 
{
	private const int LINE_LENGTH = 100;

	private LineRenderer m_Line;
	private AudioSource m_LaserSound;

	// Use this for initialization
	private void Start () 
	{
		m_Line = gameObject.GetComponent<LineRenderer> ();
		m_Line.enabled = false;
		m_LaserSound = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	private void Update ()
	{
		if (GvrPointerInputModule.Pointer.TriggerDown) 
		{
			StopCoroutine ("fireLaser");
			StartCoroutine ("fireLaser");
		}
	}

	private IEnumerator fireLaser()
	{
		m_Line.enabled = true;
		while (GvrPointerInputModule.Pointer.Triggering) 
		{
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;
			m_Line.SetPosition (0, ray.origin);
			if (m_LaserSound.isPlaying == false) {
				m_LaserSound.Play();
			}

			if (Physics.Raycast (ray, out hit, LINE_LENGTH)) 
			{
				m_Line.SetPosition (1, hit.point);
				if ((true == hit.collider) && (true == hit.collider.transform.gameObject.name.Contains("Target")))
				{
					if (hit.collider.transform.gameObject.name.Contains ("Friendly")) 
					{
						hit.collider.transform.gameObject.SendMessage("DoWhenFriendHitted");
					} 
					else 
					{
						hit.collider.transform.gameObject.SendMessage("DoWhenTargetHitted");
					}
				}
			} 
			else
			{
				m_Line.SetPosition (1, ray.GetPoint (LINE_LENGTH));
			}

			yield return null;
		}

		m_Line.enabled = false;
		m_LaserSound.Stop();
	}
}
