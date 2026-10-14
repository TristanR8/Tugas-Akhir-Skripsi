using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private GameObject ScreenWin;

    [SerializeField] private Text coinText;
    [SerializeField] private BintangManager starManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScreenWin.SetActive(true); 
            Time.timeScale = 0f;
            AudioManager.Instance.StopBGM();
            AudioManager.Instance.PlaySFX("Win");
        }
        // Ambil coin level
        int coin = CoinManager.Instance.levelCoin;

        // Tampilkan jumlah coin
        coinText.text = coin.ToString();

        // Atur bintang
        starManager.Setstar(coin);
    }

}