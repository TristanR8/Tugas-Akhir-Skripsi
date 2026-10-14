using System.Collections.Generic;
using UnityEngine;

public class Informasi : MonoBehaviour
{
    public float waktuHidup;

    void OnEnable()
    {
        // Menjalankan hitung mundur setiap kali objek aktif
        StartCoroutine(HilangSetelahWaktu());
    }

    System.Collections.IEnumerator HilangSetelahWaktu()
    {
        yield return new WaitForSeconds(waktuHidup);
        gameObject.SetActive(false); // Objek menjadi tidak aktif (tersembunyi)
    }
}
