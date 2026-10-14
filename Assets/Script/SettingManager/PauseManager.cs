using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject ScreenPause;

    public void Pause()
    {
        ScreenPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        ScreenPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
