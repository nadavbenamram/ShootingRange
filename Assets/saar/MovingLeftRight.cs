using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLeftRight : MonoBehaviour, IRunningScript {
    [SerializeField] float m_MovingSpeed = 11f;
    Vector3 m_MovingDirection;
    [SerializeField] float m_LeftCap = 3f;
    [SerializeField] float m_RightCap = 22f;
    bool m_IsScriptRunning = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (m_IsScriptRunning)
        {
            moveObject();
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

    void moveObject ()
    {
        if (transform.position.x <= m_LeftCap)
        {
            m_MovingDirection = transform.up * 1f;
            transform.position.Set(m_LeftCap + 0.01f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= m_RightCap)
        {
            m_MovingDirection = transform.up * -1f;
            transform.position.Set(m_RightCap - 0.01f, transform.position.y, transform.position.z);
        }
        transform.position += m_MovingDirection * Time.deltaTime * m_MovingSpeed;
    }
}
