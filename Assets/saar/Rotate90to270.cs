using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate90to270 : MonoBehaviour {
    [SerializeField] Vector3 m_RotationDirection = Vector3.forward;
    float m_RotationSpeed = 170f;
    [SerializeField] bool m_IsScriptRunning = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (m_IsScriptRunning)
        {
            transform.Rotate(m_RotationDirection, Time.deltaTime * m_RotationSpeed);
        }
    }

    public bool IsScriptRunning
    {
        get
        {
            return this.m_IsScriptRunning;
        }
        set
        {
            this.m_IsScriptRunning = value;
        }
    }
}