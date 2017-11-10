using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour 
{
	private Text m_PointsText = null;

	// Use this for initialization
	void Start () 
	{
		m_PointsText = GetComponent<Text> () as Text;
	}

	// Update is called once per frame
	void Update () 
	{
		m_PointsText.text = PlayerController.GetPoints();
	}
}