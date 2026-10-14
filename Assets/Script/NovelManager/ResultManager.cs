using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public Text coinText;
    public Text benarText;
    public Text nilaiText;

    void Start()
    {
        nilaiText.text = QuizManager.Instance.GetScore().ToString();

        benarText.text = QuizManager.Instance.correctAnswer.ToString();

        coinText.text = PlayerPrefs.GetInt("LEVEL_COIN", 0).ToString();
    }
}
