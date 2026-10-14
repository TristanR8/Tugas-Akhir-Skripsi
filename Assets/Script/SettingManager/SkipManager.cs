using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipManager : MonoBehaviour
{
    public void SkipChat()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }
}

