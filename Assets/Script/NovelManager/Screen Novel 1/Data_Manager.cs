using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class Data_Manager : MonoBehaviour
{
    [SerializeField] private GameObject ScreenDataMurid;
    [SerializeField] private GameObject ScreenPilihan;

    public void ToScreenPilihan()
    {
        ScreenDataMurid.SetActive(false);
        ScreenPilihan.SetActive(true);
        Time.timeScale = 0;
    }
}
