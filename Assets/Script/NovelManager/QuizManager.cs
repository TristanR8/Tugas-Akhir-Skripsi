using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public static QuizManager Instance;

    public int correctAnswer = 0;
    public int totalQuestion = 5;

    // Status jawaban tiap soal
    private bool soal1 = false;
    private bool soal2 = false;
    private bool soal3 = false;
    private bool soal4 = false;
    private bool soal5 = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //================ SOAL 1 ================
    public void JawabanBenar1()
    {
        if (!soal1)
        {
            soal1 = true;
            correctAnswer++;
        }
    }

    public void JawabanSalah1()
    {
        if (soal1)
        {
            soal1 = false;
            correctAnswer--;
        }
    }

    //================ SOAL 2 ================
    public void JawabanBenar2()
    {
        if (!soal2)
        {
            soal2 = true;
            correctAnswer++;
        }
    }

    public void JawabanSalah2()
    {
        if (soal2)
        {
            soal2 = false;
            correctAnswer--;
        }
    }

    //================ SOAL 3 ================
    public void JawabanBenar3()
    {
        if (!soal3)
        {
            soal3 = true;
            correctAnswer++;
        }
    }

    public void JawabanSalah3()
    {
        if (soal3)
        {
            soal3 = false;
            correctAnswer--;
        }
    }

    //================ SOAL 4 ================
    public void JawabanBenar4()
    {
        if (!soal4)
        {
            soal4 = true;
            correctAnswer++;
        }
    }

    public void JawabanSalah4()
    {
        if (soal4)
        {
            soal4 = false;
            correctAnswer--;
        }
    }

    //================ SOAL 5 ================
    public void JawabanBenar5()
    {
        if (!soal5)
        {
            soal5 = true;
            correctAnswer++;
        }
    }

    public void JawabanSalah5()
    {
        if (soal5)
        {
            soal5 = false;
            correctAnswer--;
        }
    }

    public int GetWrongAnswer()
    {
        return totalQuestion - correctAnswer;
    }

    public int GetScore()
    {
        return (correctAnswer * 100) / totalQuestion;
    }

    public void ResetQuiz()
    {
        correctAnswer = 0;

        soal1 = false;
        soal2 = false;
        soal3 = false;
        soal4 = false;
        soal5 = false;
    }
}