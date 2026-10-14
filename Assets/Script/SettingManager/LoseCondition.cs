using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    [SerializeField] public GameObject LoseScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TopPlayer"))
        {
            Time.timeScale = 0;
            Debug.Log("Kamu kalah!");
            LoseScreen.SetActive(true);
            AudioManager.Instance.StopBGM();
            AudioManager.Instance.PlaySFX("Lose");
        }
    }

}
