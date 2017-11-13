using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeaponController : MonoBehaviour 
{
	public void SelectWeapon(string i_Key)
	{
		PlayerController.SelectedWeapon = i_Key;
		Debug.Log ("selcted weapon = " + i_Key);
    }
}
