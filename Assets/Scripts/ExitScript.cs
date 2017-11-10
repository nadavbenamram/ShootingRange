using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour {
	private const float TIME_TO_EXIT = 5f;
	private float m_Counter;

	public void Start()
	{
		m_Counter = TIME_TO_EXIT;
	}

	public void Update()
	{
		m_Counter -= Time.deltaTime;
		if (m_Counter <= 0) 
		{
			exitGame ();
		}
	}

	private void exitGame()
	{
		Application.Quit ();
	}
}
