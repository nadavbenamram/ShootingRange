using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public string NextLevel;
	public int NumOfTargets;
	public int BasicPointPerTarget;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void TargetHitted()
	{
		PlayerController.AddPoints (BasicPointPerTarget);
		NumOfTargets--;
		if (NumOfTargets <= 0) {
			PlayerController.NextLevel ();
			SceneManager.LoadScene (NextLevel);
		}
	}

	public void FriendHitted()
	{
		PlayerController.AddPoints (BasicPointPerTarget * -1);
	}
}
