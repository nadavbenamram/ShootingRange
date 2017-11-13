using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnPlace : MonoBehaviour, IRunningScript {
    [SerializeField] float m_RotationSpeed = 80f;
    bool m_IsScriptRunning = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (m_IsScriptRunning)
        {
            transform.Rotate(Vector3.back, Time.deltaTime * m_RotationSpeed);
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
