using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour {
    [SerializeField] bool m_ShouldDropTarget;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int x = (int)transform.rotation.eulerAngles.x;
        if (transform.parent.parent.name == "Target_4")
        {
            //Debug.Log(((int)transform.rotation.eulerAngles.x).ToString());
            Debug.Log(!(x >= 270 && x <= 300));
            Debug.Log(x);
        }
        if (m_ShouldDropTarget && !(x >= 270))
        {
            transform.Rotate(15, 0, 0, Space.World);
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
