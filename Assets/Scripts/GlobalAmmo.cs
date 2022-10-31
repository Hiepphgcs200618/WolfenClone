using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int[] loaded_Ammo = {0,0,0};
    public static int[] stock_Ammo = {0,0,0};
    public int indexGun;
    public GameObject ammoDisplay;
    void Update() {
        indexGun = WeaponHolder.currentGun;
        ammoDisplay.GetComponent<Text>().text = "" + loaded_Ammo[indexGun] + "/" + stock_Ammo[indexGun];
    }
}
