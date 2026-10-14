using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class ScreenB2_Materi : MonoBehaviour
{
    [SerializeField] private GameObject Materi1;
    [SerializeField] private GameObject Materi2;
    [SerializeField] private GameObject Materi3;
    [SerializeField] private GameObject Materi4;
    [SerializeField] private GameObject Materi5;

    public void ToMateri2()
    {
        Materi1.SetActive(true);
        Materi2.SetActive(true);
        Materi3.SetActive(false);
        Materi4.SetActive(false);
        Materi5.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToMateri3()
    {
        Materi1.SetActive(true);
        Materi2.SetActive(true);
        Materi3.SetActive(true);
        Materi4.SetActive(false);
        Materi5.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToMateri4()
    {
        Materi1.SetActive(true);
        Materi2.SetActive(true);
        Materi3.SetActive(true);
        Materi4.SetActive(true);
        Materi5.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ToMateri5()
    {
        Materi1.SetActive(true);
        Materi2.SetActive(true);
        Materi3.SetActive(true);
        Materi4.SetActive(true);
        Materi5.SetActive(true);
        Time.timeScale = 0f;
    }
}
