using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
    [SerializeField] bool m_ShouldDropTarget;
    int m_NumOfRotations = 6;
    bool m_DidGetInitialRotation = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ShouldDropTarget && m_NumOfRotations > 0)
        {
            if (!m_DidGetInitialRotation)
            {
                int x = (int)transform.rotation.eulerAngles.x;

                if (x > 0 && x <= 90)
                {
                    m_NumOfRotations = m_NumOfRotations + (x / 15) + 1;
                }

                m_DidGetInitialRotation = true;
            }

            transform.Rotate(15, 0, 0, Space.World);
            m_NumOfRotations--;
        }
    }

    public bool ShouldDropTarget
    {
        get
        {
            return this.m_ShouldDropTarget;
        }
        set
        {
            this.m_ShouldDropTarget = value;
        }
    }
}
