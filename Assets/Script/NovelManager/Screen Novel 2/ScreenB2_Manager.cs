using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenB2_Manager : MonoBehaviour
{
    [SerializeField] private GameObject Screen1;
    [SerializeField] private GameObject Screen2;
    [SerializeField] private GameObject Screen3;
    [SerializeField] private GameObject Screen4;
    [SerializeField] private GameObject Screen5;
    [SerializeField] private GameObject Screen6;
    [SerializeField] private GameObject Screen7;
    [SerializeField] private GameObject Screen8;
    [SerializeField] private GameObject WinScreen;

    public void ToScreen1()
    {
        Screen1.SetActive(true);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen2()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen3()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(true);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen4()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(true);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen5()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(true);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen6()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(true);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen7()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(true);
        Screen8.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen8()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(true);
        WinScreen.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToWinScreen()
    {
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Screen8.SetActive(false);
        WinScreen.SetActive(true);
        Time.timeScale = 0f;
        AudioManager.Instance.StopBGM();
        AudioManager.Instance.PlaySFX("Win");
    }
}
