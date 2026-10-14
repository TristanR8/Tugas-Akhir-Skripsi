using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    [SerializeField] private GameObject GasRem;

    // Tambahkan parameter "bool status" di dalam kurung
    public void UIHandphone(bool status)
    {
        // Nilai SetActive akan mengikuti centang Toggle (true/false)
        GasRem.SetActive(status);
        Time.timeScale = 1f;

        Debug.Log("Status UI HP: " + status); // opsional untuk cek di Console
    }
}