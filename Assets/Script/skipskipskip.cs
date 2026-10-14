using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipskipskip : MonoBehaviour
{
    public int idScene;
    public void Level_Selanjutnya()
    {
        Time.timeScale = 1f;
        ParentScene.sceneAsal = idScene;
        SceneManager.LoadScene("Novel 2");
    }
}
