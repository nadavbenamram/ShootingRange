using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishGameScript : MonoBehaviour
{
	public Text Points;
	public Text Time;
	private float m_TimeToExit = 5f;

	// Use this for initialization
	void Start () 
	{
		Points.text = PlayerController.GetPoints ();
		Time.text = PlayerController.GetTotalTime ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_TimeToExit -= UnityEngine.Time.deltaTime;
		if (m_TimeToExit <= 0) {
			SceneManager.LoadScene (0);
		}
	}
}
