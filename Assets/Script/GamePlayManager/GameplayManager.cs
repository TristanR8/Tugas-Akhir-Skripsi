using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public int idScene;
    public void Level_Ulang()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }

    public void Level_Ulang2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
    }

    public void Level_Ulang3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 3");
    }

    public void Level_Keluar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title Screen");
    }

    public void Level_Selanjutnya()
    {
        Time.timeScale = 1f;
        ParentScene.sceneAsal = idScene;
        SceneManager.LoadScene("Novel 2");
    }
}
