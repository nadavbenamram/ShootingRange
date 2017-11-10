using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSceneScript : MonoBehaviour
{
	public void SaveScene()
	{
		PlayerPrefs.SetString ("SavedScene", SceneManager.GetActiveScene().name);
	}
}
