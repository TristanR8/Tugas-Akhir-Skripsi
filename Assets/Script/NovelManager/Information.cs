using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    [SerializeField] private GameObject ScreenInformation1;
    [SerializeField] private GameObject ScreenInformation2;
    [SerializeField] private GameObject ScreenInformation3;

    public void Information1()
    {
        ScreenInformation1.SetActive(true);
        ScreenInformation2.SetActive(false);
        ScreenInformation3.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Information2()
    {
        ScreenInformation1.SetActive(false);
        ScreenInformation2.SetActive(true);
        ScreenInformation3.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Information3()
    {
        ScreenInformation1.SetActive(false);
        ScreenInformation2.SetActive(false);
        ScreenInformation3.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Default()
    {
        ScreenInformation1.SetActive(false);
        ScreenInformation2.SetActive(false);
        ScreenInformation3.SetActive(false);
        Time.timeScale = 1f;
    }
}
