using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class TargetMeshController : MonoBehaviour
{
	public LevelManager CurrentLevel;
    bool m_WasHit = false;
    private static readonly Object lockObj = new Object();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
        string gameObjectName = col.gameObject.name;

        //We didn't use tag because it's didn't work on Android device.
        if (gameObjectName.Contains("FireBall") || gameObjectName.Contains("GunShot"))
        {
            Destroy(col.gameObject);

            if (this.gameObject.name.Contains("Friendly"))
            {
                DoWhenFriendHitted();
            }
            else
            {
                DoWhenTargetHitted();
            }
        }
	}

	public void DoWhenTargetHitted()
	{
        lock (lockObj)
        {
            if (!m_WasHit)
            {
                m_WasHit = true;
                dropTarget();
                CurrentLevel.TargetHitted ();
            }
         }
	}

	public void DoWhenFriendHitted()
	{
        lock (lockObj)
        {
            if (!m_WasHit)
            {
                dropTarget();
		        CurrentLevel.FriendHitted ();
            }
        }
    }

    private void dropTarget()
    {
        IRunningScript runningScript = getRunningScript();

        if(runningScript != null)
        {
            runningScript.IsScriptRunning = false;
        }

        gameObject.GetComponent<DropTarget>().ShouldDropTarget = true;
    }

    private IRunningScript getRunningScript()
    {
        IRunningScript runningScript = null;

        if (gameObject.GetComponents<Moving_Up_Down>().Length != 0)
        {
            runningScript = gameObject.GetComponent<Moving_Up_Down>();
        }
        else if (gameObject.GetComponents<Rotate90to270>().Length != 0)
        {
            runningScript = gameObject.GetComponent<Rotate90to270>();
        }
        else if (gameObject.GetComponents<MovingLeftRight>().Length != 0)
        {
            runningScript = gameObject.GetComponent<MovingLeftRight>();
        }
        else if (gameObject.GetComponents<RotateUpDown>().Length != 0)
        {
            runningScript = gameObject.GetComponent<RotateUpDown>();
        }
        else if (gameObject.GetComponents<RotateOnPlace>().Length != 0)
        {
            runningScript = gameObject.GetComponent<RotateOnPlace>();
        }

        return runningScript;
    }
}
