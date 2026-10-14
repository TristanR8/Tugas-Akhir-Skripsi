using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TampilkanNamaPemain : MonoBehaviour
{
    public Text namaText;

    private void Start()
    {
        string nama = PlayerPrefs.GetString("PlayerName", "");
        namaText.text = nama;
    }
}
