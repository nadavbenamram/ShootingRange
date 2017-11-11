using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMeshController : MonoBehaviour 
{
	public LevelManager CurrentLevel;
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
		if (gameObjectName.Contains("FireBall") || gameObjectName.Contains("GunShot")) {
			Destroy (col.gameObject);
			if (this.gameObject.name.Contains ("Friendly")) 
			{
				DoWhenFriendHitted ();
			} 
			else 
			{
				DoWhenTargetHitted();
			}
		}
	}

	public void DoWhenTargetHitted()
	{
		Destroy (gameObject);
		CurrentLevel.TargetHitted ();
	}

	public void DoWhenFriendHitted()
	{
		Destroy (gameObject);
		CurrentLevel.FriendHitted ();
	}
}
