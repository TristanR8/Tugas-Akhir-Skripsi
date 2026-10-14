using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    public void LoadGameplay()
    {
        Debug.Log("Lanjut Ke Gameplay");
        SceneManager.LoadScene("Novel 1");
    }
}
