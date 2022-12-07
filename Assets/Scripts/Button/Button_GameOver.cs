using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_GameOver : MonoBehaviour
{
    void Start() 
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(GlobalSceneIndex.currentIndex);
        GlobalAmmo.loaded_Ammo[0] = GlobalSceneIndex.loaded_Ammo_start[0];
        GlobalAmmo.loaded_Ammo[1] = GlobalSceneIndex.loaded_Ammo_start[1];
        GlobalAmmo.loaded_Ammo[2] = GlobalSceneIndex.loaded_Ammo_start[2];
        GlobalAmmo.stock_Ammo[0] = GlobalSceneIndex.stock_Ammo_start[0];
        GlobalAmmo.stock_Ammo[1] = GlobalSceneIndex.stock_Ammo_start[1];
        GlobalAmmo.stock_Ammo[2] = GlobalSceneIndex.stock_Ammo_start[2];
        GlobalHP.valueHP = GlobalSceneIndex.hp_start;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
