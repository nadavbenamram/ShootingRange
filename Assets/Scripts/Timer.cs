using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
	public static Stopwatch StopWatch;
	private Text m_CounterText = null;

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
		m_CounterText.text = GetTimeAsString (StopWatch.Elapsed);
	}

	private static string makeItDoubleDigit(int i_Number)
	{
		if (i_Number.ToString ().Length == 1) {
			return "0" + i_Number;
		} 
		else
		{
			return i_Number.ToString ();
		}
	}

	public static string GetTimeAsString(System.TimeSpan i_TimeSpan)
	{
		return makeItDoubleDigit(i_TimeSpan.Hours) + ":" + makeItDoubleDigit(i_TimeSpan.Minutes) + ":" + makeItDoubleDigit(i_TimeSpan.Seconds);
	}
}
