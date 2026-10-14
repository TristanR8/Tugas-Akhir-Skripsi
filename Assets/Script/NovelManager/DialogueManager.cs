using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject[] screendialogue;

    void Start()
    {
        foreach (GameObject s in screendialogue)
        {
            s.SetActive(false);
        }
        screendialogue[ParentScene.sceneAsal - 1].SetActive(true);
    }
}