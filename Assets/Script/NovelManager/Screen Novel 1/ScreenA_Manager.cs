using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenA_Manager : MonoBehaviour
{
    [SerializeField] private GameObject ScreenPilihan;
    [SerializeField] private GameObject Screen1;
    [SerializeField] private GameObject Screen2;
    [SerializeField] private GameObject Screen3;
    [SerializeField] private GameObject Screen4;
    [SerializeField] private GameObject Screen5;
    [SerializeField] private GameObject Screen6;
    [SerializeField] private GameObject Screen7;

    public void ToScreenPilihan()
    {
        ScreenPilihan.SetActive(true);
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen1()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(true);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen2()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(false);
        Screen2.SetActive(true);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen3()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(true);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen4()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(true);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen5()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(true);
        Screen6.SetActive(false);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen6()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(true);
        Screen7.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToScreen7()
    {
        ScreenPilihan.SetActive(false);
        Screen1.SetActive(false);
        Screen2.SetActive(false);
        Screen3.SetActive(false);
        Screen4.SetActive(false);
        Screen5.SetActive(false);
        Screen6.SetActive(false);
        Screen7.SetActive(true);
        Time.timeScale = 0f;
    }
}
