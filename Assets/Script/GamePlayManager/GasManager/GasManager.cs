using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasManager : MonoBehaviour
{
    public float maxgas = 100f;
    public float currentgas;

    public float gasDecreaseRate = 5f; // per detik
    public Slider gasBar;

    public GameObject losePanel;

    void Start()
    {
        currentgas = maxgas;
        UpdateUI();
    }

    void Update()
    {
        // bensin berkurang terus
        currentgas -= gasDecreaseRate * Time.deltaTime;

        if (currentgas <= 0)
        {
            currentgas = 0;
            AudioManager.Instance.StopBGM();
            AudioManager.Instance.PlaySFX("Lose");
            GameOver();
        }

        UpdateUI();
    }

    public void Addgas(float amount)
    {
        currentgas += amount;

        if (currentgas > maxgas)
            currentgas = maxgas;
    }

    void UpdateUI()
    {
        if (gasBar != null)
            gasBar.value = currentgas / maxgas;
    }

    void GameOver()
    {
        Debug.Log("Bensin habis!");

        if (losePanel != null)

            losePanel.SetActive(true);

        Time.timeScale = 0f;
    }
}
