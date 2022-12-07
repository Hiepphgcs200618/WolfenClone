using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalSceneIndex : MonoBehaviour
{
    private Scene scene;
    public static int currentIndex;
    public static int[] loaded_Ammo_start ={0,0,0};
    public static int[] stock_Ammo_start = {0,0,0};
    public static int hp_start;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        scene = SceneManager.GetActiveScene();
        currentIndex = scene.buildIndex;
        loaded_Ammo_start[0] = GlobalAmmo.loaded_Ammo[0];
        loaded_Ammo_start[1] = GlobalAmmo.loaded_Ammo[1];
        loaded_Ammo_start[2] = GlobalAmmo.loaded_Ammo[2];
        stock_Ammo_start[0] = GlobalAmmo.stock_Ammo[0];
        stock_Ammo_start[1] = GlobalAmmo.stock_Ammo[1];
        stock_Ammo_start[2] = GlobalAmmo.stock_Ammo[2];
        hp_start = GlobalHP.valueHP;
    }
}
