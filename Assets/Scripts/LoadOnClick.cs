using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {
	public void LoadScene(int scene)
	{
		SceneManager.LoadScene (scene);
	}

	static public void LoadSavedScene()
	{
		string sceneKey = PlayerPrefs.GetString ("SavedScene");
		SceneManager.LoadScene (sceneKey);
	}

	public void LoadActiveLevel()
	{
		SceneManager.LoadScene (PlayerController.ActiveLevel);
	}
}
