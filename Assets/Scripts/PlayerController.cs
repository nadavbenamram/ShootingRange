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
	private const string DEFAULT_WEAPON_KEY = GUN_KEY; //Gun is the default weapon;
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

		//set default weapon active
		m_ActiveWeapon = m_Weapons [DEFAULT_WEAPON_KEY];
		m_ActiveWeapon.SetActive (true);
	}

	public void SwitchWeapon(string i_WeaponKey)
	{
		m_ActiveWeapon.SetActive (false);
		m_ActiveWeapon = m_Weapons [i_WeaponKey];
		m_ActiveWeapon.SetActive (true);
	}
}

public class PlayerController : MonoBehaviour 
{
	private WeaponsManager m_WeaponManager;
	// Use this for initialization
	void Start () 
	{
		m_WeaponManager = new WeaponsManager ();
	}

	string[] test = { "laser", "fireball", "gun" }; 
	int i = 0;
	// Update is called once per frame
	bool wasdown = false;
	void Update () {
		bool down = Input.GetMouseButton(1);
		if (down && !wasdown) 
		{
			m_WeaponManager.SwitchWeapon (test[i%3]);
			i++;
		}

		wasdown = down;
	}
}
