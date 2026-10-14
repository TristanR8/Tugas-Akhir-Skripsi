using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenAkhirManager : MonoBehaviour
{
    public void ToLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }

    public void ToLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
    }

    public void ToLevel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 3");
    }
}
