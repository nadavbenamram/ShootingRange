using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
	public static Stopwatch StopWatch;
	private Text m_CounterText = null;
	private bool m_PrevIsRunning = false;

	static Timer()
	{
		StopWatch = new Stopwatch();
	}

	// Use this for initialization
	void Start () 
	{
		m_CounterText = GetComponent<Text> () as Text;
	}

	// Update is called once per frame
	void Update () 
	{
		m_CounterText.text = makeItDoubleDigit(StopWatch.Elapsed.Hours) + ":" + makeItDoubleDigit(StopWatch.Elapsed.Minutes) + ":" + makeItDoubleDigit(StopWatch.Elapsed.Seconds);
	}

	private string makeItDoubleDigit(int i_Number)
	{
		if (i_Number.ToString ().Length == 1) {
			return "0" + i_Number;
		} 
		else
		{
			return i_Number.ToString ();
		}
	}
}
