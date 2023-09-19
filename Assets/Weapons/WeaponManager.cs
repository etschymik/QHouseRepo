using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public int totalWeapons;
    public int currentWeaponIndex;

    public GameObject[] weapons;
    public GameObject weaponManager;
    public GameObject currentWeapon;

    void Start()
    {
        totalWeapons = weaponManager.transform.childCount;
        weapons = new GameObject[totalWeapons];

        for (int i = 0; i < totalWeapons; i++)
        {
            weapons[i] = weaponManager.transform.GetChild(i).gameObject;
            weapons[i].SetActive(false);
        }

        weapons[0].SetActive(true);
        currentWeapon = weapons[0];
    }

    void Update()
    {
        // next weapon
        if (Input.GetKeyDown(KeyCode.E))
        {
            weapons[currentWeaponIndex].SetActive(false);
            currentWeaponIndex++;
            // loops if needed
            if (currentWeaponIndex == totalWeapons)
            {
                currentWeaponIndex = 0;
            }
            weapons[currentWeaponIndex].SetActive(true);
            currentWeapon = weapons[currentWeaponIndex];
        }

        // previous weapon
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weapons[currentWeaponIndex].SetActive(false);
            currentWeaponIndex--;
            // loops if needed
            if (currentWeaponIndex == -1)
            {
                currentWeaponIndex = totalWeapons - 1;
            }
            weapons[currentWeaponIndex].SetActive(true);
            currentWeapon = weapons[currentWeaponIndex];
        }

        // switches gun with numbers
        if (Input.inputString != "")
        {
            int asciiCode = System.Convert.ToInt32(Input.inputString[0]);
            int key = (int)(asciiCode - KeyCode.Alpha1 + 1);
            if (key >= 1 && key <= totalWeapons)
            {
                weapons[currentWeaponIndex].SetActive(false);
                currentWeaponIndex = key - 1;
                weapons[currentWeaponIndex].SetActive(true);
                currentWeapon = weapons[currentWeaponIndex];
            }
        }
    }
}
