using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamaPemain : MonoBehaviour
{
    public InputField InputNama;

    public void SimpanNamaPemain()
    {
        PlayerPrefs.SetString("PlayerName", InputNama.text);
        PlayerPrefs.Save();

        Debug.Log("Nama tersimpan: " + InputNama.text);
    }
}
