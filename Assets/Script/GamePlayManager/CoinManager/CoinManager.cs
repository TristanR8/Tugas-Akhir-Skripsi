using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    public int totalCoin = 0; // coin permanen
    public int levelCoin = 0; // coin level sekarang
    public Text coinText;

    void Awake()
    { 
        Instance = this;

        // Ambil total coin dari save
        totalCoin = PlayerPrefs.GetInt("COIN", 0);

        // Reset coin level
        levelCoin = 0;
        PlayerPrefs.SetInt("LEVEL_COIN", 0);
        PlayerPrefs.Save();

        UpdateUI();
    }

    public void AddCoin(int amount)
    {
        // Tambah total permanen
        totalCoin += amount;

        // Tambah coin level
        levelCoin += amount;

        // Simpan keduanya
        PlayerPrefs.SetInt("COIN", totalCoin);
        PlayerPrefs.SetInt("LEVEL_COIN", levelCoin);
        PlayerPrefs.Save();

        UpdateUI();
    }

    void UpdateUI()
    {
        if (coinText != null)
            coinText.text = levelCoin.ToString();
    }
}