using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Up_Down : MonoBehaviour, IRunningScript {
    [SerializeField] float m_MovingSpeed = 2f;
    Vector3 m_MovingDirection;
    readonly float k_BottomCap = 3f;
    readonly float k_TopCap = 6f;
    bool m_IsScriptRunning = true;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
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

    void moveObject()
    {
        if (transform.position.y <= k_BottomCap)
        {
            m_MovingDirection = transform.forward * -1f;
            transform.position.Set(transform.position.x, k_BottomCap + 0.01f, transform.position.z);
        } else if (transform.position.y >= k_TopCap)
        {
            m_MovingDirection = transform.forward * 1f;
            transform.position.Set(transform.position.x, k_TopCap - 0.01f, transform.position.z);
        }
        transform.position += m_MovingDirection * Time.deltaTime * m_MovingSpeed;

    }
}