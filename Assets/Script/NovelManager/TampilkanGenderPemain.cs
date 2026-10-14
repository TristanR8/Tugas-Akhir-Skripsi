using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TampilkanGenderPemain : MonoBehaviour
{
    public GameObject KarakterLakiLaki;
    public GameObject KarakterPerempuan;

    void Start()
    {
        int gender = PlayerPrefs.GetInt("Gender", 0);

        if (gender == 0)
        {
            KarakterLakiLaki.SetActive(true);
            KarakterPerempuan.SetActive(false);
        }
        else if (gender == 1)
        {
            KarakterLakiLaki.SetActive(false);
            KarakterPerempuan.SetActive(true);
        }
    }
}
