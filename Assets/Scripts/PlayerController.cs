using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GVR;

public class WeaponsManager
{
	private const int NUM_OF_WEAPONS = 3;
	private const string GUN_KEY = "gun";
	private const string LASER_KEY = "laser";
	private const string FIREBALL_KEY = "fireball";
	private const string GUN_PREFAB_NAME = "Gun";
	private const string LASER_PREFAB_NAME = "Laser";
	private const string FIREBALL_PREFAB_NAME = "Fireball";
	private Dictionary<string, GameObject> m_Weapons;
	private GameObject m_ActiveWeapon;

	public WeaponsManager()
	{
		init ();
	}

	private void init()
	{
		m_Weapons = new Dictionary<string, GameObject> (NUM_OF_WEAPONS);
		m_Weapons [GUN_KEY] = GameObject.Find (GUN_PREFAB_NAME);
		m_Weapons [LASER_KEY] = GameObject.Find (LASER_PREFAB_NAME);
		m_Weapons [FIREBALL_KEY] = GameObject.Find (FIREBALL_PREFAB_NAME);

		//Inactive all the weapons
		foreach (GameObject gameObject in m_Weapons.Values) 
		{
			gameObject.SetActive (false);
		}
	}

	public void SwitchWeapon(string i_WeaponKey)
	{
		if (m_ActiveWeapon != null) 
		{
			m_ActiveWeapon.SetActive (false);
		}

		m_ActiveWeapon = m_Weapons [i_WeaponKey];
		m_ActiveWeapon.SetActive (true);
	}
}

public class PlayerController : MonoBehaviour 
{
	private const string DEFAULT_WEAPN_KEY = "gun";

	private WeaponsManager m_WeaponManager;
	public static string SelectedWeapon = DEFAULT_WEAPN_KEY;

	// Use this for initialization
	void Start () 
	{
		m_WeaponManager = new WeaponsManager ();
		setWeapon (SelectedWeapon);
		Debug.Log ("Player started with weapon = " + SelectedWeapon);
	}

	void Update () 
	{
		
	}

	private void setWeapon(string i_WeaponKey)
	{
		m_WeaponManager.SwitchWeapon (i_WeaponKey);
	}
}
