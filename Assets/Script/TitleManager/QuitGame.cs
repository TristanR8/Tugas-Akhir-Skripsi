using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ClearGame()
    {
        Debug.Log("Game Keluar!");
        Application.Quit();
    }
}
